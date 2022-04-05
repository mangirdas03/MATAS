using System;
using System.Collections.Generic;

#nullable disable

namespace PVP.Models
{
    public partial class Info
    {
        public int Id { get; set; }
        public int FkDeviceId { get; set; }
        public DateTime DateTime { get; set; }
        public int Wattage { get; set; }

        public virtual Device FkDevice { get; set; }
    }
}
