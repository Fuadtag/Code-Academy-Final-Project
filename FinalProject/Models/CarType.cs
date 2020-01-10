using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class CarType
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage ="Must not be more than 50 symbol")]
        public string Icon { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
