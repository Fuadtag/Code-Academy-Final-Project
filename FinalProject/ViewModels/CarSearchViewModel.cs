using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.ViewModels
{
    public class CarSearchViewModel
    {
        public ICollection<Car> Cars { get; set; }

        public ICollection<CustomerReview> CustomerReviews { get; set; }
    }
}
