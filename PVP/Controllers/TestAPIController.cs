using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PVP.ViewModels;

namespace PVP.Controllers
{
    [Route("fetch")]
    [ApiController]
    public class TestAPIController : ControllerBase
    {


        [HttpPost("wattage")]
        public IActionResult GetData(Data data)
        {
            //throw new Exception("test");
            return Ok("Watage: " + data.Wattage);
        }
    }

}
