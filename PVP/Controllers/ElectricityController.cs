using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PVP.Controllers
{
    public class ElectricityController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }


    }
}
