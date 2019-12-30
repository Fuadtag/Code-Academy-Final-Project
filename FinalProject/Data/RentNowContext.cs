using FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Data
{
    public class RentNowContext:DbContext
    {
        public RentNowContext(DbContextOptions<RentNowContext> options) : base(options)
        {

        }

        public DbSet<Setting> Settings { get; set; }
        public DbSet<CarType> CarTypes { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<WhyPeopleLikeUs> WhyPeopleLikeUs { get; set; }
    }
}
