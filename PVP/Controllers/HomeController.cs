﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PVP.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BCryptNet = BCrypt.Net.BCrypt;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using PVP.ViewModels;
using PVP.Helpers;

namespace PVP.Controllers
{
    public class HomeController : Controller
    {
        private readonly pvpContext _context;
        private readonly JwtService _jwtservice;

        public HomeController(pvpContext context, JwtService jwtservice)
        {
            _context = context;
            _jwtservice = jwtservice;
        }


        public IActionResult Index()
        {
            return View();
        }


        [Route("login")]
        public IActionResult Login()
        {
            return View();
        }


        [Route("register")]
        public IActionResult Register()
        {
            return View();
        }


        [Route("register")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(RegisterDTO registerdto)
        {
            if (_context.Users.FirstOrDefault(x => x.Mail.Equals(registerdto.Mail)) != null)
            {
                ModelState.AddModelError("Mail", "Naudotojas jau registruotas!");
            }
            if (!ModelState.IsValid)
            {
                return View();
            }
            //string mySalt = BCryptNet.GenerateSalt();
            var user = new User
            {
                Mail = registerdto.Mail,
                PassHash = BCryptNet.HashPassword(registerdto.Password),
            };
            _context.Users.Add(user);
            _context.SaveChanges();


            TempData["RegisterSuccessMessage"] = "RegisterSuccess";
            //return RedirectToAction("login");
            return View();
        }


        [Route("login")]
        [HttpPost]
        public IActionResult Login(LoginDTO logindto)
        {

            User user = FindUserByName(logindto.Mail);

            if (user == null)
            {
                //return Json("Invalid", JsonRequestBehavior.AllowGet);
                //ModelState.AddModelError(string.Empty, "The user name or password is incorrect");
                ViewBag.PromptMessage = "invalidCredentials";
                return View(logindto);
                //return (RedirectToAction("Error"));
            }

                //return (RedirectToAction("Error"));

            if (!BCryptNet.Verify(logindto.Password, user.PassHash))
            {
                //return (RedirectToAction("Error"));
                ViewBag.PromptMessage = "invalidCredentials";
                return View(logindto);
            }

            var jwt = _jwtservice.Generate(user.Id);
            //HttpContext.Session.SetString("Token", jwt);

            Response.Cookies.Append("jwt", jwt, new CookieOptions
            {
                HttpOnly = true
            });
            TempData["LoginSuccessMessage"] = "LoginSuccess";
            return (RedirectToAction("Index"));
        }

        private User FindUserByName(string mail)
        {
            return _context.Users.FirstOrDefault(e => e.Mail == mail);
        }
        private User FindUserById(int id)
        {
            return _context.Users.FirstOrDefault(e => e.Id == id);
        }


        [HttpGet("user")]
        public IActionResult UserSettings()
        {
            try
            {
                var jwt = Request.Cookies["jwt"];
                //var jwt = HttpContext.Session.GetString("Token");
                var token = _jwtservice.Verify(jwt);
                int userId = int.Parse(token.Issuer);
                var user = FindUserById(userId);
                return (RedirectToAction("Index"));
            }
            catch (Exception)
            {
                return (RedirectToAction("Login"));
            }
        }

        [Route("logout")]
        public IActionResult Logout()
        {
            //HttpContext.Session.Remove("Token");
            //Response.Cookies.Delete("jwt");
            //TempData["LogoutSuccessMessage"] = "LogoutSuccess";
            //return (RedirectToAction("Index"));
            try
            {
                var jwt = Request.Cookies["jwt"];
                var token = _jwtservice.Verify(jwt);
                int userId = int.Parse(token.Issuer);
                //var user = FindUserById(userId);

                Response.Cookies.Delete("jwt");
                TempData["LogoutSuccessMessage"] = "LogoutSuccess";
                return (RedirectToAction("Index"));
            }
            catch (Exception)
            {
                return (RedirectToAction("Login"));
            }

        }



        [Route("devices")]
        public async Task<IActionResult> Devices()
        {
            try
            {
                var jwt = Request.Cookies["jwt"];
                //var jwt = HttpContext.Session.GetString("Token");
                var token = _jwtservice.Verify(jwt);
                int userId = int.Parse(token.Issuer);
                //var user = FindUserById(userId);
                var devices = await _context.Devices.Where(e => e.FkUser.Equals(userId)).ToListAsync(); // users' devices
                return View(devices);
            }
            catch (Exception)
            {
                return (RedirectToAction("Login", "Home"));
            }
        }



        [HttpPost]
        public IActionResult UpdateTag([FromBody] TagJSON data)
        {
            try
            {
                var jwt = Request.Cookies["jwt"];
                //var jwt = HttpContext.Session.GetString("Token");
                var token = _jwtservice.Verify(jwt);
                int userId = int.Parse(token.Issuer);
                //var user = FindUserById(userId);
                //var devices = await _context.Devices.Where(e => e.FkUser.Equals(userId)).ToListAsync(); // users' devices
                //return View(devices);
                if (data.tag.Length > 50)
                    return NotFound();


                var device = _context.Devices.FirstOrDefault(i => i.Id.Equals(data.id));
                if (device != null)
                    device.Tag = data.tag;

                //rti.Wattage = data.Wattage;

                _context.Update(device);
                _context.SaveChanges();

                // return Error;
                return Ok();
            }
            catch (Exception)
            {
                return (RedirectToAction("Login", "Home"));
            }
        }

        [HttpPost]
        public IActionResult NewDevice([FromBody] DeviceJSON data)
        {
            try
            {
                var jwt = Request.Cookies["jwt"];
                //var jwt = HttpContext.Session.GetString("Token");
                var token = _jwtservice.Verify(jwt);
                int userId = int.Parse(token.Issuer);
                //var user = FindUserById(userId);

                if (_context.Devices.FirstOrDefault(e => e.SetupString.Equals(data.setupString)) != null)
                    return BadRequest("Toks įrenginys jau naudojamas!");

                if(_context.ManufacturedDevices.FirstOrDefault(e => e.SetupString.Equals(data.setupString)) != null)
                {
                    Device tempDevice = new Device
                    {
                        FkUser = userId,
                        IsOn = true,
                        IsRealtime = false,
                        SetupString = data.setupString,
                        Tag = data.tag,
                        Treshold = null
                    };
                    _context.Devices.Add(tempDevice);
                    _context.SaveChanges();
                    var device = _context.Devices.FirstOrDefault(e => e.SetupString.Equals(data.setupString));
                    Realtimeinfo rti = new Realtimeinfo
                    {
                        FkDeviceId = device.Id,
                        Wattage = 0
                    };
                    _context.Realtimeinfos.Add(rti);
                    _context.SaveChanges();
                    return Ok();
                }
                else
                {
                    return NotFound("Įrenginys nerastas!");
                }
            }
            catch (Exception)
            {
                return (RedirectToAction("Login", "Home"));
            }
        }





        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
