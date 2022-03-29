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
        private readonly PVPContext _context;
        private readonly JwtService _jwtservice;

        public HomeController(PVPContext context, JwtService jwtservice)
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
            if(!ModelState.IsValid)
            {
                return View();
            }
            //string mySalt = BCryptNet.GenerateSalt();
            var user = new User
            {
                mail = registerdto.Mail,
                pass_hash = BCryptNet.HashPassword(registerdto.Password),
            };
            _context.Users.Add(user);
            _context.SaveChanges();

            return RedirectToAction("login");
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

            if (!BCryptNet.Verify(logindto.Password, user.pass_hash))
            {
                //return (RedirectToAction("Error"));
                ViewBag.PromptMessage = "invalidCredentials";
                return View(logindto);
            }

            var jwt = _jwtservice.Generate(user.id);
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
            return _context.Users.FirstOrDefault(e => e.mail == mail);
        }
        private User FindUserById(int id)
        {
            return _context.Users.FirstOrDefault(e => e.id == id);
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
                var user = FindUserById(userId);

                Response.Cookies.Delete("jwt");
                TempData["LogoutSuccessMessage"] = "LogoutSuccess";
                return (RedirectToAction("Index"));
            }
            catch (Exception)
            {
                return (RedirectToAction("Login"));
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
