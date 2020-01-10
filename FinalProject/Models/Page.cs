using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Page
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName ="ntext")]
        public string Text { get; set; }
    }
}
