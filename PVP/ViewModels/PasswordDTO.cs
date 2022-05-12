using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PVP.ViewModels
{
    public class PasswordDTO
    {
        [Required(ErrorMessage = "Įveskite esamą slaptažidį!")]
        [MaxLength(40, ErrorMessage = "Slaptažodis neteisingas!")]
        [MinLength(6, ErrorMessage = "Slaptažodis neteisingas!")]
        public string OldPassword { get; set; }

        [Required(ErrorMessage = "Įveskite naują slaptažodį!")]
        [MaxLength(40, ErrorMessage = "Slaptažodis per ilgas!")]
        [MinLength(6, ErrorMessage = "Slaptažodis turi būti bent 6 simbolių ilgio!")]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "Įveskite slaptažodį dar kartą!")]
        [Compare("NewPassword", ErrorMessage = "Slaptažodžiai turi sutapti!")]
        public string ConfirmPassword { get; set; }
    }
}
