using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModels
{
    public class LoginRequest
    {
        [Required(ErrorMessage = "SubCode is required")]

    
        public string SubCode { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

    }
}
