using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PVP.ViewModels
{
    public class RegisterDTO
    {
        [Required(ErrorMessage = "Įveskite el. pašto adresą!")]
        [MaxLength(20, ErrorMessage = "El. paštas per ilgas!")]
        [MinLength(6, ErrorMessage = "El. paštas turi būti bent 6 simbolių ilgio!")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Įveskite slaptažodį!")]
        [MaxLength(20, ErrorMessage = "Slaptažodis per ilgas!")]
        [MinLength(6, ErrorMessage = "Slaptažodis turi būti bent 6 simbolių ilgio!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Įveskite slaptažodį dar kartą!")]
        [Compare("Password", ErrorMessage = "Slaptažodžiai turi sutapti!")]
        public string ConfirmPassword { get; set; }
    }
}
