using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PVP.Models;
using PVP.Helpers;

namespace PVP.Controllers
{
    public class ElectricityController : Controller
    {
        private readonly pvpContext _context;
        private readonly JwtService _jwtservice;

        public ElectricityController(pvpContext context, JwtService jwtservice)
        {
            _context = context;
            _jwtservice = jwtservice;
        }

        [Route("live-statistics")]
        public IActionResult Statistics1()
        {
            try
            {
                var jwt = Request.Cookies["jwt"];
                //var jwt = HttpContext.Session.GetString("Token");
                var token = _jwtservice.Verify(jwt);
                int userId = int.Parse(token.Issuer);
                var user = FindUserById(userId);
                var devices = _context.Devices.Where(e => e.FkUser.Equals(userId)); // users' devices
                return View(devices);
            }
            catch (Exception)
            {
                return (RedirectToAction("Login", "Home"));
            }
        }
        private User FindUserById(int id)
        {
            return _context.Users.FirstOrDefault(e => e.Id == id);
        }

        [HttpGet]
        public IActionResult LiveWattage(int device_id)
        {
            try
            {
                var jwt = Request.Cookies["jwt"];
                if (jwt == null)
                    return Unauthorized("Authorization error.");
                var token = _jwtservice.Verify(jwt);
                int userId = int.Parse(token.Issuer);
                var user = FindUserById(userId);
                var device = _context.Devices.FirstOrDefault(d => d.Id.Equals(device_id));

                if (user != null && device != null && user.Id == device.FkUser)
                {
                    var rti = _context.Realtimeinfos.FirstOrDefault(i => i.FkDeviceId.Equals(device_id));
                    if (rti == null)
                        return Unauthorized("Error has occured.");
                    return Ok(rti.Wattage);

                }
                else return Unauthorized("Authorization error.");
            }
            catch (Exception)
            {
                return Unauthorized("Error has occured.");
            }

        }
    }
}
