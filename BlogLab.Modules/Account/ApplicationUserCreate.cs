using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable

namespace BlogLab.Modules.Account
{
    public class ApplicationUserCreate : ApplicationUserLogin
    {
      
        [MinLength(10)]
        [MaxLength(30)]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Email is Required")]
        [MaxLength(30, ErrorMessage = "Max 30 characters")]
        [EmailAddress(ErrorMessage = "Invalid Email format")]
        public string Email { get; set; } 


    }
}
