using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Tag
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(200, ErrorMessage ="Must not be more than 20 symbol")]
        public string Name { get; set; }
        [Required]
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
