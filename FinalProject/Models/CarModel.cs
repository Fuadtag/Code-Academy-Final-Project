using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class CarModel
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(40, ErrorMessage ="Must not be more than 40 symbol")]
        public string Name { get; set; }
        public int CarBrandId { get; set; }
        public CarBrand CarBrand { get; set; }

        public ICollection<Car> Cars { get; set; }
    }
}
