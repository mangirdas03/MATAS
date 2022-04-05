using System;
using System.Collections.Generic;

#nullable disable

namespace PVP.Models
{
    public partial class Realtimeinfo
    {
        public int Id { get; set; }
        public int FkDeviceId { get; set; }
        public int Wattage { get; set; }
    }
}
