﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Partner
    {
        public int Id { get; set; }
        public IFormFile PhotoFile { get; set; }
        public string Photo { get; set; }
        public string Name { get; set; }

    }
}
