using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectIA_renting_Cars.Models
{
    public class CarCateogryViewModel
    {
        public Car car { get; set; }
        public IEnumerable<category> Category { get; set; }
    }
}