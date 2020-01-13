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
        [MaxLength(200)]
        public string Icon { get; set; }
        [Required]
        [MaxLength(200, ErrorMessage = "Must not be more than 200 symbol")]
        public string Title { get; set; }
        [Required]
        [MaxLength(200, ErrorMessage = "Must not be more than 200 symbol")]
        public string Text { get; set; }
    }
}
