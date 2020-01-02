using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.ViewModels
{
    public class AboutUsViewModel
    {
        
        public ICollection<OurVision> Visions { get; set; }

        public Passion  Passion { get; set; }

        public ICollection<Team> Teams { get; set; }
        public ICollection<Partner> Partners { get; set; }

    }
}
