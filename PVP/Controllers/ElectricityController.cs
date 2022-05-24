using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PVP.Models;
using PVP.Helpers;
using Microsoft.EntityFrameworkCore;
using PVP.ViewModels;
using System.Globalization;
using ReflectionIT.Mvc.Paging;


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

        // Device select page
        public async Task<IActionResult> DeviceSelect()
        {
            try
            {
                var jwt = Request.Cookies["jwt"];
                if(jwt == null || jwt == "")
                    return (RedirectToAction("Login", "Home"));
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

        // Device statistics page
        public async Task<IActionResult> Statistics(int id, int pageIndex = 1, string sortExpression = "-DateTime")
        {
            try
            {
                var jwt = Request.Cookies["jwt"];
                var token = _jwtservice.Verify(jwt);
                int userId = int.Parse(token.Issuer);
                var device = await _context.Devices.Where(e => e.FkUser.Equals(userId)).FirstOrDefaultAsync(f => f.Id.Equals(id)); // device

                List<Info> infos = new List<Info>(); // infos from selected user's devices

                var temp =  _context.Infos.Where(e => e.FkDeviceId.Equals(device.Id)).OrderByDescending(f => f.DateTime);
                infos.AddRange(temp);

                var model = await PagingList.CreateAsync(temp, 15, pageIndex, sortExpression, "-DateTime");

                model.Action = "Statistics";
                ViewData["SortParam"] = sortExpression;
                if(device.Tag == null || device.Tag == "")
                    ViewData["DeviceName"] = device.SetupString;
                else ViewData["DeviceName"] = device.Tag;
                return View(model);
            }
            catch (Exception)
            {
                return (RedirectToAction("Login", "Home"));
            }
        }

        // Live statistics page
        [Route("Live-statistics")]
        public async Task<IActionResult> Statistics1()
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

        // Find user object by id
        private User FindUserById(int id)
        {
            return _context.Users.FirstOrDefault(e => e.Id == id);
        }


        // grazina live statistics page'ui duomenis (kvieciamas kas 1.5 sek)
        [HttpGet]
        public async Task<IActionResult> LiveWattage(int device_id)
        {
            try
            {
                var jwt = Request.Cookies["jwt"];
                if (jwt == null)
                    return Unauthorized("Authorization error.");
                var token = _jwtservice.Verify(jwt);
                int userId = int.Parse(token.Issuer);
                var user = FindUserById(userId);
                var device = await _context.Devices.FirstOrDefaultAsync(d => d.Id.Equals(device_id));

                if (user != null && device != null && user.Id == device.FkUser)
                {
                    if (!device.IsOn)
                        return Ok(-1);
                    var rti = await _context.Realtimeinfos.FirstOrDefaultAsync(i => i.FkDeviceId.Equals(device_id));
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

        // Panaikina viena statistikos 'info' irasa
        [HttpPost]
        public async Task<IActionResult> RemoveEntry([FromBody] ParamJSON data)
        {
            try
            {
                var jwt = Request.Cookies["jwt"];
                var token = _jwtservice.Verify(jwt);
                int userId = int.Parse(token.Issuer);

                var info = await _context.Infos.FirstOrDefaultAsync(e => e.Id.Equals(data.id));
                if (info != null)
                {
                    _context.Infos.Remove(info);
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


        // Grazina 'info' duomenis JSON formatu grafiko braizymui
        [HttpGet]
        public IActionResult GetStatistics(int device_id, string start, string end)
        {
            List<Info> info = new List<Info>();
            List<StatisticsJSON> sjson = new List<StatisticsJSON>();

            try
            {
                if(end == null)
                {
                    int parsedDays = Int32.Parse(start);
                    // Pasirinkto irenginio infos nuo kazkiek dienu atgal iki dabar
                    info.AddRange(_context.Infos.Where(e => e.FkDeviceId.Equals(device_id)).Where(e => e.DateTime >= (DateTime.Now.AddHours(3)).AddDays(-parsedDays)).OrderBy(e => e.DateTime));
                }
                else
                {
                    DateTime startDate = DateTime.ParseExact(start, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                    DateTime endDate = DateTime.ParseExact(end, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                    endDate = endDate.AddDays(1);

                    if (startDate >= endDate)
                        return BadRequest("Bad interval.");
                    else if((endDate - startDate).TotalDays > 60)
                        return BadRequest("Interval too long.");

                    info.AddRange(_context.Infos.Where(e => e.FkDeviceId.Equals(device_id)).Where(e => e.DateTime >= startDate).Where(e => e.DateTime <= endDate).OrderBy(e => e.DateTime));
                }

                List<DateTime> days = info.Select(e => e.DateTime.Date).Distinct().ToList(); // list of unique dates

                for (int i = 0; i < days.Count; i++)
                {
                    decimal value = 0; //int count = 0;

                    //int value = info.Where(e => e.DateTime.Date.Equals(days[i])).Select(e => e.Wattage).Max();

                    for (int j = 0; j < info.Count; j++)
                    {
                        if (info[j].DateTime.Date.Equals(days[i]))
                        {
                            value += info[j].Wattage;
                            //count++;
                        }
                    }
                    //value /= count;

                    var stat = new StatisticsJSON
                    {
                        date = days[i].ToString("MM/dd"),
                        wattage = value
                    };
                    sjson.Add(stat);
                    value = 0; //count = 0;
                }
                return Ok(sjson);
            }
            catch
            {
                return NotFound();
            }

        }

    }
}
