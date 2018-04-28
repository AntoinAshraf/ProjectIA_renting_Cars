using ProjectIA_renting_Cars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectIA_renting_Cars.ViewModels
{
    public class CarCategory
    {
        public IEnumerable<Car> Car { get; set; }
       
        public IEnumerable<category> Category { get; set; }
         
    }
}