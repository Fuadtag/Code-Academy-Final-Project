﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Passion
    {

        public int Id { get; set; }
        [NotMapped]
        public IFormFile PhotoFile { get; set; }
        [MaxLength(70)]
        public string Photo { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "Must not be more than 20 symbol")]
        public string SubTitle { get; set; }
        [MaxLength(20, ErrorMessage = "Must not be more than 20 symbol")]
        public string Title { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage ="Must not be more than 100 symbol")]
        public string Text { get; set; }

    }
}
