using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SMVC.Models
{
    public class RegisterCreateVM
    {
        [DisplayName("First Name")]
        [Required]
        public string CustomerFirstName { get; set; }

        [DisplayName("Last Name")]
        [Required]
        public string CustomerLastName { get; set; }

        [DisplayName("Email")]
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [DisplayName("Phone Number")]
        [Required]
        [Phone]
        public string CustomerPhoneNumber { get; set; }
    }
}
