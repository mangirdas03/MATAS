using System;
using System.Collections.Generic;

#nullable disable

namespace PVP.Models
{
    public partial class User
    {
        public User()
        {
            Devices = new HashSet<Device>();
        }

        public int Id { get; set; }
        public string Mail { get; set; }
        public string PassHash { get; set; }

        public virtual ICollection<Device> Devices { get; set; }
    }
}
