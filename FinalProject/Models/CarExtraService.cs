using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class CarExtraService
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(200, ErrorMessage ="Must not be more than 20 symbol")]
        public string Name { get; set; }
        [Column(TypeName ="Money")]
        public decimal Price { get; set; }

        public int? OrderItemId { get; set; }
        public OrderItem OrderItem { get; set; }

    }
}
