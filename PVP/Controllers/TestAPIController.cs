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
    [Route("fetch")]
    [ApiController]
    public class TestAPIController : ControllerBase
    {
        private readonly PVPContext _context;
        private readonly JwtService _jwtservice;

        public TestAPIController(PVPContext context, JwtService jwtservice)
        {
            _context = context;
            _jwtservice = jwtservice;
        }

        [HttpPost("wattage")]
        public IActionResult ReceiveWattage(Data data)
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
    }

}
