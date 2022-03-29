using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PVP.ViewModels;
using Microsoft.Extensions.Logging;
using PVP.Models;
using System.Diagnostics;
using BCryptNet = BCrypt.Net.BCrypt;
using Microsoft.EntityFrameworkCore;
using PVP.Helpers;

namespace PVP.Controllers
{
    [Route("api")]
    [ApiController]
    public class APIController : ControllerBase
    {
        private readonly PVPContext _context;
        private readonly JwtService _jwtservice;

        public APIController(PVPContext context, JwtService jwtservice)
        {
            _context = context;
            _jwtservice = jwtservice;
        }

        [HttpPost("wattage")]
        public IActionResult ReceiveWattage(WattageJSON data)
        {
            try
            {
                var device = _context.Devices.FirstOrDefault(e => e.setup_string == data.id);
                if(device == null)
                    return Unauthorized("Authorization error.");
                var info = new Info
                {
                    fk_device_id = device.id,
                    date_time = DateTime.Now,
                    wattage = data.Wattage
                };
                _context.Infos.Add(info);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                return Unauthorized("Error has occured.");
            }
            //throw new Exception("test");
            return Ok("Wattage received: " + data.Wattage);
        }

        private User FindUserById(int id)
        {
            return _context.Users.FirstOrDefault(e => e.id == id);
        }

        [HttpGet("wattage/{device_id}")]
        public IActionResult LiveWattage(int device_id)
        {
            try
            {
                var jwt = Request.Cookies["jwt"];
                if(jwt == null) 
                    return Unauthorized("Authorization error.");
                var token = _jwtservice.Verify(jwt);
                int userId = int.Parse(token.Issuer);
                var user = FindUserById(userId);
                var device = _context.Devices.FirstOrDefault(d => d.id.Equals(device_id));

                if(user != null && device != null && user.id == device.fk_user)
                {
                    var rti = _context.RealtimeInfos.FirstOrDefault(i => i.fk_device_id.Equals(device_id));
                    if (rti == null)
                        return Unauthorized("Error has occured.");
                    return Ok(rti.wattage);

                }
                else return Unauthorized("Authorization error.");
            }
            catch (Exception)
            {
                return Unauthorized("Error has occured.");
            }

        }


        [HttpPost("livewattage")]
        public IActionResult ReceiveLiveWattage(WattageJSON data)
        {
            try
            {
                var device = _context.Devices.FirstOrDefault(e => e.setup_string == data.id);
                if (device == null)
                    return Unauthorized("Authorization error.");

                var rti = _context.RealtimeInfos.FirstOrDefault(i => i.fk_device_id.Equals(device.id));
                rti.wattage = data.Wattage;

                _context.Update(rti);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                return Unauthorized("Error has occured.");
            }
            //throw new Exception("test");
            return Ok("Wattage received: " + data.Wattage);
        }
    }

}
