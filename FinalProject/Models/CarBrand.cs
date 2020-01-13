using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class CarBrand
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(200, ErrorMessage ="Must not be more than 30 symbol")]
        public string Name { get; set; }
        public ICollection<CarModel> CarModels { get; set; }

    }
}
