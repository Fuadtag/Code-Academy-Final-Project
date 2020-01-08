using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class CarBrand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<CarModel> CarModels { get; set; }

    }
}
