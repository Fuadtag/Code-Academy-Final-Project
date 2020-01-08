using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }

        public int CarId { get; set; }
        public Car Car { get; set; }
        public ICollection<CarExtraService> Services { get; set; }

    }
}
