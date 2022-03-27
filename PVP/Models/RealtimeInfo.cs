using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PVP.Models
{
    public class RealtimeInfo
    {
        public int id { get; set; }
        public int fk_device_id { get; set; } // fk
        public int wattage { get; set; }

    }
}
