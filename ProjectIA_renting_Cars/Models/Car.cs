using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectIA_renting_Cars.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Car_Model { get; set; }
        public string Car_Name { get; set; }
        public bool Is_Available { get; set; }
        public string Car_Color { get; set; }
        public IEnumerable<Byte> Car_Photo { get; set; }
        public category Category { get; set; }
        public User Rented_To { get; set; }
        public DateTime? Rented_From { get; set; }
        public DateTime? Rented_Till { get; set; }
    }
}