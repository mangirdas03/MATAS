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
        private readonly pvpContext _context;
        private readonly JwtService _jwtservice;

        public APIController(pvpContext context, JwtService jwtservice)
        {
            _context = context;
            _jwtservice = jwtservice;
        }
        // test
        //[HttpPost("wattage")]
        //public IActionResult ReceiveWattage(WattageJSON data)
        //{
        //    try
        //    {
        //        var device = _context.Devices.FirstOrDefault(e => e.SetupString == data.id);
        //        if(device == null)
        //            return Unauthorized("Authorization error.");
        //        var info = new Info
        //        {
        //            FkDeviceId = device.Id,
        //            DateTime = DateTime.Now,
        //            Wattage = data.Wattage
        //        };
        //        _context.Infos.Add(info);
        //        _context.SaveChanges();
        //    }
        //    catch (Exception)
        //    {

        //        return Unauthorized("Error has occured.");
        //    }
        //    //throw new Exception("test");
        //    return Ok("Wattage received: " + data.Wattage);
        //}

        //private User FindUserById(int id)
        //{
        //    return _context.Users.FirstOrDefault(e => e.Id == id);
        //}

        //[HttpGet("wattage/{device_id}")]
        //public IActionResult LiveWattage(int device_id)
        //{
        //    try
        //    {
        //        var jwt = Request.Cookies["jwt"];
        //        if(jwt == null) 
        //            return Unauthorized("Authorization error.");
        //        var token = _jwtservice.Verify(jwt);
        //        int userId = int.Parse(token.Issuer);
        //        var user = FindUserById(userId);
        //        var device = _context.Devices.FirstOrDefault(d => d.Id.Equals(device_id));

        //        if(user != null && device != null && user.Id == device.FkUser)
        //        {
        //            var rti = _context.Realtimeinfos.FirstOrDefault(i => i.FkDeviceId.Equals(device_id));
        //            if (rti == null)
        //                return Unauthorized("Error has occured.");
        //            return Ok(rti.Wattage);

        //        }
        //        else return Unauthorized("Authorization error.");
        //    }
        //    catch (Exception)
        //    {
        //        return Unauthorized("Error has occured.");
        //    }

        //}


        [HttpPost("livewattage")]
        public IActionResult ReceiveLiveWattage(WattageJSON data)
        {
            try
            {
                var device = _context.Devices.FirstOrDefault(e => e.SetupString == data.id);
                if (device == null)
                    return Unauthorized("Authorization error.");

                if (device.IsOn)
                {
                    var rti = _context.Realtimeinfos.FirstOrDefault(i => i.FkDeviceId.Equals(device.Id));
                    rti.Wattage = data.Wattage;

                    _context.Update(rti);
                    _context.SaveChanges();
                }
                return Ok(device.IsOn);
            }
            catch (Exception)
            {

                return Unauthorized("Error has occured.");
            }
            //throw new Exception("test");
            //return Ok("Wattage received: " + data.Wattage);

        }

        [HttpPost("wattage")]
        public IActionResult ReceiveWattage(WattageJSON data)
        {
            try
            {
                var device = _context.Devices.FirstOrDefault(e => e.SetupString == data.id);
                if (device == null)
                    return Unauthorized("Authorization error.");

                Info info = new Info
                {
                    FkDeviceId = device.Id,
                    DateTime = DateTime.Now.AddHours(3),
                    Wattage = data.Wattage
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

        [HttpGet("status/{id}")]
        public async Task<IActionResult> GetStatus(string id)
        {
            var device = await _context.Devices.FirstOrDefaultAsync(e => e.SetupString.Equals(id));
            if (device != null)
            {
                return Ok(device.IsOn);
            }
            return Unauthorized("Error has occured.");
        }


    }
}
