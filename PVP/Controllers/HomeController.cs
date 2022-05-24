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
            var jwt = Request.Cookies["jwt"];
            if (jwt != null && jwt != "")
                return (RedirectToAction("DeviceSelect", "Electricity"));
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
            var jwt = Request.Cookies["jwt"];
            if (jwt != null && jwt != "")
                return (RedirectToAction("DeviceSelect", "Electricity"));
            return View();
        }

        // register page
        [Route("Register")]
        public IActionResult Register()
        {
            var jwt = Request.Cookies["jwt"];
            if (jwt != null && jwt != "")
                return (RedirectToAction("DeviceSelect", "Electricity"));
            return View();
        }

        // user settings page
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
            var user = new User
            {
                Mail = registerdto.Mail,
                PassHash = BCryptNet.HashPassword(registerdto.Password),
                Created = DateTime.Now.AddHours(3)
            };
            _context.Users.Add(user);
            _context.SaveChanges();

            TempData["RegisterSuccessMessage"] = "RegisterSuccess";
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
                ViewBag.PromptMessage = "invalidCredentials";
                return View(logindto);
            }
            if (!BCryptNet.Verify(logindto.Password, user.PassHash))
            {
                //return (RedirectToAction("Error"));
                ViewBag.PromptMessage = "invalidCredentials";
                return View(logindto);
            }

            var jwt = _jwtservice.Generate(user.Id);

            Response.Cookies.Append("jwt", jwt, new CookieOptions
            {
                HttpOnly = true
            });
            TempData["LoginSuccessMessage"] = "LoginSuccess";
            return (RedirectToAction("DeviceSelect", "Electricity"));
        }

        // finds user object by name
        private User FindUserByName(string mail)
        {
            return _context.Users.FirstOrDefault(e => e.Mail == mail);
        }
        // finds user object by id
        private User FindUserById(int id)
        {
            return _context.Users.FirstOrDefault(e => e.Id == id);
        }

        // Settings password reset POST
        [Route("Settings")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Settings(PasswordDTO passwordDTO)
        {
            try
            {
                var jwt = Request.Cookies["jwt"];
                var token = _jwtservice.Verify(jwt);
                int userId = int.Parse(token.Issuer);
                var user = FindUserById(userId);

                //// Uzkraunami puslapio duomenys po POST
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
                await _context.SaveChangesAsync();
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
            try
            {
                var jwt = Request.Cookies["jwt"];
                var token = _jwtservice.Verify(jwt);
                int userId = int.Parse(token.Issuer);

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
                var token = _jwtservice.Verify(jwt);
                int userId = int.Parse(token.Issuer);
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
        public async Task<IActionResult> UpdateTag([FromBody] ParamJSON data)
        {
            try
            {
                var jwt = Request.Cookies["jwt"];
                var token = _jwtservice.Verify(jwt);
                int userId = int.Parse(token.Issuer);

                if (data.value.Length > 50)
                    return NotFound("Blogi duomenys.");

                var device = await _context.Devices.FirstOrDefaultAsync(i => i.Id.Equals(data.id));
                if (device != null)
                    device.Tag = data.value;

                _context.Update(device);
                await _context.SaveChangesAsync();

                return Ok();
            }
            catch (Exception)
            {
                return NotFound("Aut. klaida");
            }
        }

        // update device treshold
        [HttpPost]
        public async Task<IActionResult> UpdateTreshold([FromBody] ParamJSON data)
        {
            try
            {
                var jwt = Request.Cookies["jwt"];
                var token = _jwtservice.Verify(jwt);
                int userId = int.Parse(token.Issuer);

                decimal tresh;
                if (data.value.Length > 10 || !decimal.TryParse(data.value, out tresh))
                    return NotFound("Blogi duomenys");

                var device = await _context.Devices.FirstOrDefaultAsync(i => i.Id.Equals(data.id));
                if (device != null)
                {
                    ///// Notification reset
                    if (device.Treshold != tresh)
                        device.IsRealtime = false;
                    /////

                    if (tresh == 0)
                        device.Treshold = 0;
                    else device.Treshold = tresh;

                }

                _context.Update(device);
                await _context.SaveChangesAsync();
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
        public async Task<IActionResult> UpdateTariff([FromBody] ParamJSON data)
        {
            try
            {
                var jwt = Request.Cookies["jwt"];
                var token = _jwtservice.Verify(jwt);
                int userId = int.Parse(token.Issuer);

                decimal tar;
                if (data.value.Length > 10 || !decimal.TryParse(data.value, out tar))
                    return NotFound("Blogi duomenys");

                var device = await _context.Devices.FirstOrDefaultAsync(i => i.Id.Equals(data.id));
                if (device != null)
                    if (tar == 0)
                        device.Tariff = 0;
                    else device.Tariff = tar;

                _context.Update(device);
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch (Exception)
            {
                return NotFound("Aut. klaida");
            }
        }

        // add new device
        [HttpPost]
        public async Task<IActionResult> NewDevice([FromBody] DeviceJSON data)
        {
            try
            {
                var jwt = Request.Cookies["jwt"];
                //var jwt = HttpContext.Session.GetString("Token");
                var token = _jwtservice.Verify(jwt);
                int userId = int.Parse(token.Issuer);
                //var user = FindUserById(userId);

                if (await _context.Devices.FirstOrDefaultAsync(e => e.SetupString.Equals(data.setupString)) != null)
                    return BadRequest("Toks įrenginys jau naudojamas!");

                if(await _context.ManufacturedDevices.FirstOrDefaultAsync(e => e.SetupString.Equals(data.setupString)) != null)
                {
                    Device tempDevice = new Device
                    {
                        FkUser = userId,
                        IsOn = false,
                        IsRealtime = false,
                        SetupString = data.setupString,
                        Tag = data.tag,
                        Treshold = 0
                    };
                    await _context.Devices.AddAsync(tempDevice);
                    await _context.SaveChangesAsync();
                    var device = await _context.Devices.FirstOrDefaultAsync(e => e.SetupString.Equals(data.setupString));
                    Realtimeinfo rti = new Realtimeinfo
                    {
                        FkDeviceId = device.Id,
                        Wattage = 0
                    };
                    _context.Realtimeinfos.Add(rti);
                    await _context.SaveChangesAsync();
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
        public async Task<IActionResult> ClearStatistics([FromBody] ParamJSON data)
        {
            try
            {
                var jwt = Request.Cookies["jwt"];
                var token = _jwtservice.Verify(jwt);
                int userId = int.Parse(token.Issuer);

                var device = await _context.Devices.FirstOrDefaultAsync(e => e.Id.Equals(data.id));
                if (device.FkUser.Equals(userId))
                {
                    var rowsToDelete = _context.Infos.Where(e => e.FkDeviceId.Equals(data.id));
                    _context.Infos.RemoveRange(rowsToDelete);
                    device.IsRealtime = false;
                    _context.Devices.Update(device);
                    await _context.SaveChangesAsync();
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
        public async Task<IActionResult> RemoveDevice([FromBody] ParamJSON data)
        {
            try
            {
                var jwt = Request.Cookies["jwt"];
                var token = _jwtservice.Verify(jwt);
                int userId = int.Parse(token.Issuer);

                var device = await _context.Devices.FirstOrDefaultAsync(e => e.Id.Equals(data.id));
                if (device.FkUser.Equals(userId))
                {
                    var statistics = _context.Infos.Where(e => e.FkDeviceId.Equals(data.id));
                    var realtime = _context.Realtimeinfos.Where(e => e.FkDeviceId.Equals(data.id));
                    _context.Infos.RemoveRange(statistics);
                    _context.Realtimeinfos.RemoveRange(realtime);
                    _context.Devices.Remove(device);
                    await _context.SaveChangesAsync();
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
        public async Task<IActionResult> ChangeStatus([FromBody] ParamJSON data)
        {
            try
            {
                var jwt = Request.Cookies["jwt"];
                var token = _jwtservice.Verify(jwt);
                int userId = int.Parse(token.Issuer);

                var device = await _context.Devices.FirstOrDefaultAsync(e => e.Id.Equals(data.id));
                if (device != null)
                {
                    if (device.IsOn == false)
                        device.IsOn = true;
                    else device.IsOn = false;


                    var rti = await _context.Realtimeinfos.FirstOrDefaultAsync(i => i.FkDeviceId.Equals(device.Id));
                    if (rti != null)
                    {
                        rti.Wattage = 0;
                        _context.Update(rti);
                    }
                    _context.Update(device);
                    await _context.SaveChangesAsync();
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
