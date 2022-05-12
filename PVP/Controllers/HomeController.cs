using Microsoft.AspNetCore.Mvc;
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

        // home page
        public IActionResult Index()
        {
            return View();
        }

        // faq page
        [Route("FAQ")]
        public IActionResult FAQ()
        {
            return View();
        }

        // login page
        [Route("Login")]
        public IActionResult Login()
        {
            return View();
        }

        // register page
        [Route("Register")]
        public IActionResult Register()
        {
            return View();
        }

        [Route("Settings")]
        public IActionResult Settings()
        {
            try
            {
                var jwt = Request.Cookies["jwt"];
                var token = _jwtservice.Verify(jwt);
                int userId = int.Parse(token.Issuer);
                var user = FindUserById(userId);
                TempData["UserEmail"] = user.Mail;
                TempData["UserDate"] = user.Created.ToString("yyyy-MM-dd HH:mm");
                int deviceCount = _context.Devices.Where(e => e.FkUser.Equals(userId)).Count();
                TempData["DeviceCount"] = deviceCount;
            }
            catch (Exception)
            {
                return (RedirectToAction("Login"));
            }
            
            return View();
        }

        // register POST
        [Route("Register")]
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
                Created = DateTime.Now.AddHours(3)
            };
            _context.Users.Add(user);
            _context.SaveChanges();


            TempData["RegisterSuccessMessage"] = "RegisterSuccess";
            //return RedirectToAction("login");
            return View();
        }


        // login POST
        [Route("Login")]
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
            return (RedirectToAction("DeviceSelect", "Electricity"));
        }

        private User FindUserByName(string mail)
        {
            return _context.Users.FirstOrDefault(e => e.Mail == mail);
        }
        private User FindUserById(int id)
        {
            return _context.Users.FirstOrDefault(e => e.Id == id);
        }


        // test page
        [Route("Settings")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Settings(PasswordDTO passwordDTO)
        {
            try
            {
                var jwt = Request.Cookies["jwt"];
                //var jwt = HttpContext.Session.GetString("Token");
                var token = _jwtservice.Verify(jwt);
                int userId = int.Parse(token.Issuer);
                var user = FindUserById(userId);

                ////
                TempData["UserEmail"] = user.Mail;
                TempData["UserDate"] = user.Created.ToString("yyyy-MM-dd HH:mm");
                int deviceCount = _context.Devices.Where(e => e.FkUser.Equals(userId)).Count();
                TempData["DeviceCount"] = deviceCount;
                ////

                if (passwordDTO.OldPassword == null || !BCryptNet.Verify(passwordDTO.OldPassword, user.PassHash))
                {
                    ModelState.AddModelError("OldPassword", "Neteisingas dabartinis slaptažodis!");
                }
                if (!ModelState.IsValid)
                {
                    return View();
                }
                user.PassHash = BCryptNet.HashPassword(passwordDTO.NewPassword);
                _context.Users.Update(user);
                _context.SaveChanges();
                TempData["PChangeSuccessMessage"] = "PChangeSuccess";
                return View();
            }
            catch (Exception)
            {
                return (RedirectToAction("Login"));
            }
        }

        // Logout
        [Route("Logout")]
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

        // ------------------------DEVICES--------------------------

        // Devices page
        [Route("Devices")]
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

        // Update device tag
        [HttpPost]
        public IActionResult UpdateTag([FromBody] ParamJSON data)
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
                if (data.value.Length > 50)
                    return NotFound("Blogi duomenys.");


                var device = _context.Devices.FirstOrDefault(i => i.Id.Equals(data.id));
                if (device != null)
                    device.Tag = data.value;

                //rti.Wattage = data.Wattage;

                _context.Update(device);
                _context.SaveChanges();

                return Ok();
            }
            catch (Exception)
            {
                return NotFound("Aut. klaida");
                //return (RedirectToAction("Login", "Home"));
            }
        }

        // update device treshold
        [HttpPost]
        public IActionResult UpdateTreshold([FromBody] ParamJSON data)
        {
            try
            {
                var jwt = Request.Cookies["jwt"];
                var token = _jwtservice.Verify(jwt);
                int userId = int.Parse(token.Issuer);

                int tresh;
                if (data.value.Length > 10 || !int.TryParse(data.value, out tresh))
                    return NotFound("Blogi duomenys");

                var device = _context.Devices.FirstOrDefault(i => i.Id.Equals(data.id));
                if (device != null)
                    if(tresh == 0)
                        device.Treshold = null;
                    else device.Treshold = tresh;

                _context.Update(device);
                _context.SaveChanges();
                return Ok();
            }
            catch (Exception)
            {
                return NotFound("Aut. klaida");
                //return (RedirectToAction("Login", "Home"));
            }
        }

        // update device tariff
        [HttpPost]
        public IActionResult UpdateTariff([FromBody] ParamJSON data)
        {
            try
            {
                var jwt = Request.Cookies["jwt"];
                var token = _jwtservice.Verify(jwt);
                int userId = int.Parse(token.Issuer);

                decimal tresh;
                if (data.value.Length > 10 || !decimal.TryParse(data.value, out tresh))
                    return NotFound("Blogi duomenys");

                var device = _context.Devices.FirstOrDefault(i => i.Id.Equals(data.id));
                if (device != null)
                    if (tresh == 0)
                        device.Tariff = 0;
                    else device.Tariff = tresh;

                _context.Update(device);
                _context.SaveChanges();
                return Ok();
            }
            catch (Exception)
            {
                return NotFound("Aut. klaida");
            }
        }

        // add new device
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
                        IsOn = false,
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
                return NotFound("Aut. klaida");
                //return (RedirectToAction("Login", "Home"));
            }
        }

        // clear device statistics
        [HttpPost]
        public IActionResult ClearStatistics([FromBody] ParamJSON data)
        {
            try
            {
                var jwt = Request.Cookies["jwt"];
                var token = _jwtservice.Verify(jwt);
                int userId = int.Parse(token.Issuer);

                var device = _context.Devices.FirstOrDefault(e => e.Id.Equals(data.id));
                if (device.FkUser.Equals(userId))
                {
                    var rowsToDelete = _context.Infos.Where(e => e.FkDeviceId.Equals(data.id));
                    _context.Infos.RemoveRange(rowsToDelete);
                    _context.SaveChanges();
                    return Ok();
                }
                else
                {
                    return NotFound("Blogi duomenys.");
                }
            }
            catch (Exception)
            {
                return NotFound("Aut. klaida");
                //return (RedirectToAction("Login", "Home"));
            }
        }

        // remove device
        [HttpPost]
        public IActionResult RemoveDevice([FromBody] ParamJSON data)
        {
            try
            {
                var jwt = Request.Cookies["jwt"];
                var token = _jwtservice.Verify(jwt);
                int userId = int.Parse(token.Issuer);

                var device = _context.Devices.FirstOrDefault(e => e.Id.Equals(data.id));
                if (device.FkUser.Equals(userId))
                {
                    var statistics = _context.Infos.Where(e => e.FkDeviceId.Equals(data.id));
                    var realtime = _context.Realtimeinfos.Where(e => e.FkDeviceId.Equals(data.id));
                    _context.Infos.RemoveRange(statistics);
                    _context.Realtimeinfos.RemoveRange(realtime);
                    _context.Devices.Remove(device);
                    _context.SaveChanges();
                    return Ok();
                }
                else
                {
                    return NotFound("Blogi duomenys.");
                }
            }
            catch (Exception)
            {
                return NotFound("Aut. klaida");
                //return (RedirectToAction("Login", "Home"));
            }
        }

        [HttpPost]
        public IActionResult ChangeStatus([FromBody] ParamJSON data)
        {
            try
            {
                var jwt = Request.Cookies["jwt"];
                var token = _jwtservice.Verify(jwt);
                int userId = int.Parse(token.Issuer);

                var device = _context.Devices.FirstOrDefault(e => e.Id.Equals(data.id));
                if (device != null)
                {
                    if (device.IsOn == false)
                        device.IsOn = true;
                    else device.IsOn = false;


                    var rti = _context.Realtimeinfos.FirstOrDefault(i => i.FkDeviceId.Equals(device.Id));
                    if (rti != null)
                    {
                        rti.Wattage = 0;
                        _context.Update(rti);
                    }
                    _context.Update(device);
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
