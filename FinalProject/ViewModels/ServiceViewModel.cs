using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.ViewModels
{
    public class ServiceViewModel
    {
        public ICollection<WhatWeOffer> Offers{ get; set; }

        public List<Testimonial> Testimonials { get; set; }
    }
}
