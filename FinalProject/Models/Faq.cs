﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Faq
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(200, ErrorMessage = "Can not be more than 200 symbol")]
        public string Question { get; set; }
        [Required]
        [MaxLength(200, ErrorMessage = "Can not be more than 200 symbol")]
        public string Answer { get; set; }
    }
}
