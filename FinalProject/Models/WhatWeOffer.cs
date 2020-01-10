using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class WhatWeOffer
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(40)]
        public string Icon { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage ="Must not be more than 50 symbol")]
        public string Title { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "Must not be more than 100 symbol")]
        public string Text { get; set; }
    }
}
