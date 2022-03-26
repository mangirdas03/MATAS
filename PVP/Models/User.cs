using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PVP.Models
{
    public class User
    {
        public int id { get; set; }

        public string mail { get; set; }

        public string pass_hash { get; set; }

    }
}
