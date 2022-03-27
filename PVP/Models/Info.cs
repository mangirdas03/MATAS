using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PVP.Models
{
    public class Info
    {
        public int id { get; set; }
        public int fk_device_id { get; set; } // fk
        public DateTime date_time { get; set; }
        public int wattage { get; set; }

        public virtual Device fk_device_idNavigation { get; set; }
    }
}
