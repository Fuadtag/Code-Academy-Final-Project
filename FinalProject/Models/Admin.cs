using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Admin
    {
        [Required]
        [MinLength(3, ErrorMessage ="Minimum length is 3")]
        [Display(Name ="Username")]
        public string Username { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required, DataType(DataType.Password), MinLength(5, ErrorMessage ="Minimum length is 5")]
        public string Password { get; set; }

        public Admin() { }

        public Admin(AppAdmin appAdmin)
        {
            Username = appAdmin.UserName;
            Email = appAdmin.Email;
            Password = appAdmin.PasswordHash;
           
        }
    }
}
