﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PVP.Models;
using PVP.Helpers;
using Microsoft.EntityFrameworkCore;
using PVP.ViewModels;

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

        // Statistics page
        [Route("statistics")]
        public async Task<IActionResult> Statistics()
        {
            try
            {
                var jwt = Request.Cookies["jwt"];
                //var jwt = HttpContext.Session.GetString("Token");
                var token = _jwtservice.Verify(jwt);
                int userId = int.Parse(token.Issuer);
                //var user = FindUserById(userId);
                var devices = _context.Devices.Where(e => e.FkUser.Equals(userId)).ToList(); // users' devices

                List<Info> infos = new List<Info>(); // infos from all user's devices
                
                foreach (var device in devices)
                {
                    var temp = await _context.Infos.Where(e => e.FkDeviceId.Equals(device.Id)).ToListAsync();
                    infos.AddRange(temp);
                }
                return View(infos);
            }
            catch (Exception)
            {
                return (RedirectToAction("Login", "Home"));
            }
        }

        // Live statistics page
        [Route("live-statistics")]
        public IActionResult Statistics1()
        {
            try
            {
                var jwt = Request.Cookies["jwt"];
                //var jwt = HttpContext.Session.GetString("Token");
                var token = _jwtservice.Verify(jwt);
                int userId = int.Parse(token.Issuer);
                //var user = FindUserById(userId);
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


        // grazina live statistics page'ui duomenis kas 5 sek.
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


        [HttpPost]
        public IActionResult RemoveEntry([FromBody] ParamJSON data)
        {
            try
            {
                var jwt = Request.Cookies["jwt"];
                var token = _jwtservice.Verify(jwt);
                int userId = int.Parse(token.Issuer);

                var info = _context.Infos.FirstOrDefault(e => e.Id.Equals(data.id));
                if (info != null)
                {
                    _context.Infos.Remove(info);
                    _context.SaveChanges();
                    return Ok();
                }
                else return BadRequest("Blogi duomenys.");

            }
            catch (Exception)
            {
                return BadRequest("Aut. klaida.");
            }
        }




    }
}
