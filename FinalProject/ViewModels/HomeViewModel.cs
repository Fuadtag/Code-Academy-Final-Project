﻿using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.ViewModels
{
    public class HomeViewModel
    {
        public List<SliderItem> Sliders { get; set; }

        public ICollection<Advantage> Advantages { get; set; }

        public ICollection<Car> Cars { get; set; }

        public ICollection<CarType> Cartypes { get; set; }

        public ICollection<Testimonial> Testimonials { get; set; }

        public ICollection<Blog> Blogs { get; set; }

    }
}
