﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Admin
    {
        public int Id { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }

        public string Token { get; set; }
    }
}
