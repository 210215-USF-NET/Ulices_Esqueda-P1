using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SMVC.Models
{
    public class LoginCreateVM
    {
        [DisplayName("Email")]
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
