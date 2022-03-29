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
        private readonly PVPContext _context;
        private readonly JwtService _jwtservice;

        public ElectricityController(PVPContext context, JwtService jwtservice)
        {
            _context = context;
            _jwtservice = jwtservice;
        }

        [Route("statistics")]
        public IActionResult Statistics1()
        {
            try
            {
                var jwt = Request.Cookies["jwt"];
                //var jwt = HttpContext.Session.GetString("Token");
                var token = _jwtservice.Verify(jwt);
                int userId = int.Parse(token.Issuer);
                var user = FindUserById(userId);
                return View();
            }
            catch (Exception)
            {
                return (RedirectToAction("Login", "Home"));
            }
        }
        private User FindUserById(int id)
        {
            return _context.Users.FirstOrDefault(e => e.id == id);
        }

    }
}
