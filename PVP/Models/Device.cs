using System;
using System.Collections.Generic;

#nullable disable

namespace PVP.Models
{
    public partial class Device
    {
        public Device()
        {
            Infos = new HashSet<Info>();
        }

        public int FkUser { get; set; }
        public bool IsOn { get; set; }
        public bool IsRealtime { get; set; }
        public string SetupString { get; set; }
        public int Id { get; set; }
        public int? Treshold { get; set; }
        public string Tag { get; set; }
        public decimal Tariff { get; set; }

        public virtual User FkUserNavigation { get; set; }
        public virtual ICollection<Info> Infos { get; set; }
    }
}
