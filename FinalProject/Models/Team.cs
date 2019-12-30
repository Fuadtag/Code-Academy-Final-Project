using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Team
    {
        public int Id { get; set; }
        public IFormFile PhotoFile { get; set; }
        public string Photo { get; set; }
        public string Name { get; set; }

        public string Position { get; set; }

        public string FacebookLink { get; set; }

        public string TwitterLink { get; set; }
        public string InstagramLink { get; set; }
        public string LinkedInLink { get; set; }
    }
}
