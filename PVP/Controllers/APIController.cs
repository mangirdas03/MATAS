using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PVP.ViewModels;
using PVP.Models;
using Microsoft.EntityFrameworkCore;
using PVP.Helpers;


namespace PVP.Controllers
{
    [Route("api")]
    [ApiController]
    public class APIController : ControllerBase
    {
        private readonly pvpContext _context;
        private readonly JwtService _jwtservice;

        public APIController(pvpContext context, JwtService jwtservice)
        {
            _context = context;
            _jwtservice = jwtservice;
        }

        // Irenginys siuncia real-time duomenis Watais, jam grazinamas jo statusas
        [HttpPost("livewattage")]
        public async Task<IActionResult> ReceiveLiveWattage(WattageJSON data)
        {
            try
            {
                var device = await _context.Devices.FirstOrDefaultAsync(e => e.SetupString == data.id);
                if (device == null)
                    return Unauthorized("Authorization error.");

                if (device.IsOn)
                {
                    var rti = await _context.Realtimeinfos.FirstOrDefaultAsync(i => i.FkDeviceId.Equals(device.Id));
                    rti.Wattage = data.Wattage;
                    
                    _context.Update(rti); 
                }

                var dateNow = DateTime.Now.AddHours(3);
                // Notification reset
                if (device.IsRealtime == true && dateNow.Hour == 00 && dateNow.Minute < 1 && dateNow.Second < 30)
                {
                    device.IsRealtime = false;
                    _context.Update(device);
                }

                await _context.SaveChangesAsync();
                return Ok(device.IsOn);
            }
            catch (Exception)
            {
                return Unauthorized("Error has occured.");
            }
        }

        // Irenginys siuncia paprastus duomenis, kvieciams email service
        [HttpPost("wattage")]
        public async Task<IActionResult> ReceiveWattage(WattageJSON data)
        {
            try
            {
                var device = await _context.Devices.FirstOrDefaultAsync(e => e.SetupString == data.id);
                if (device == null)
                    return Unauthorized("Authorization error.");

                Info info = new Info
                {
                    FkDeviceId = device.Id,
                    DateTime = DateTime.Now.AddHours(3),
                    Wattage = data.Wattage
                };
                _context.Infos.Add(info);
                _context.SaveChanges();

                //notifications
                if (device.IsRealtime == false)
                {
                    var dateNow = DateTime.Now.AddHours(3);
                    var statsSum = _context.Infos.Where(e => e.FkDeviceId.Equals(device.Id)).Where(f => f.DateTime.Date.Equals(dateNow.Date)).Select(g => g.Wattage).Sum();
                    if (statsSum > device.Treshold && device.Treshold != 0)
                    {
                        string userMail = _context.Users.FirstOrDefault(e => e.Id.Equals(device.FkUser)).Mail;
                        string title;
                        if (device.Tag == null || device.Tag == "")
                            title = device.SetupString;
                        else title = device.Tag;
                        string subject = "Įrenginio " + title + " dienos " + dateNow.ToString("MM-dd") + " limitas viršytas";
                        string text = "<h1>Jūsų nustatytas elektros sąnaudų dienos limitas viršytas!</h1>" +
                            "<p>Įrenginys: " + title + "</p>" +
                            "<p>Data: " + dateNow.ToString("yyyy-MM-dd HH:mm") + "</p>" +
                            "<p>Limitas: " + device.Treshold + " kWh</p>" +
                            "<p>Jau pasiekta: " + statsSum + " kWh</p>" +
                            "</br>" +
                            "<p>Jei nebenorite gauti šių pranešimų, panaikinkite įrenginių limitus.</p>" +
                            "<p>Šis pranešimas Jums atsiųstas automatiškai, prašome į jį neatsakinėti.</p></br><p>MATAS - Smart Energy Solutions</p>";

                        EmailService es = new EmailService();
                        bool emailSuccess = es.SendEmail(userMail, subject, text);
                        if (emailSuccess)
                        {
                            device.IsRealtime = true;
                            _context.Devices.Update(device);
                        }
                    }
                }
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                return Unauthorized("Error has occured.");
            }
            return Ok("Wattage received: " + data.Wattage);
        }

        // Irenginys siuncia GET tam, kad patikrintu savo statusa, nebenaudojamas
        [HttpGet("status/{id}")]
        public async Task<IActionResult> GetStatus(string id)
        {
            var device = await _context.Devices.FirstOrDefaultAsync(e => e.SetupString.Equals(id));
            if (device != null)
            {
                return Ok(device.IsOn);
            }
            return Unauthorized("Error has occured.");
        }


    }
}
