using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PVP.Models
{
    public class Device
    {
        public Device()
        {
            Infos = new HashSet<Info>();
        }

        public int id { get; set; }

        public int fk_user { get; set; }

        public bool is_on { get; set; }

        public bool is_realtime { get; set; }

        public string setup_string { get; set; }

        public string tag { get; set; }

        public int? treshold { get; set; }

        public virtual User fk_userNavigation { get; set; }

        public virtual ICollection<Info> Infos { get; set; }
    }
}
