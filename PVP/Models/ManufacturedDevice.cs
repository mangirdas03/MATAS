using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#nullable disable

namespace PVP.Models
{
    public partial class ManufacturedDevice
    {
        public ManufacturedDevice()
        {
        }

        public int Id { get; set; }

        public string SetupString { get; set; }
    }
}
