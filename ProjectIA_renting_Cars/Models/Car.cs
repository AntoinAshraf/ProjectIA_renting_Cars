using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectIA_renting_Cars.Models
{
    public class Car
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The Car must have a model number")]
        [Display(Name = "Car Model")]
        public string Car_Model { get; set; }

        [Required(ErrorMessage = "The Car must have Name")]
        [Display(Name = "Car Name")]
        public string Car_Name { get; set; }

        public string Car_Color { get; set; }

        [Required(ErrorMessage = "The Car must have a photo")]
        [Display(Name = "Car Photo")]
        public byte[] Car_Photo { get; set; }

        [Required(ErrorMessage = "The Car must be in a category")]
        [Display(Name = "Car Category")]
        public category Category { get; set; }
        public User Rented_To { get; set; }
        public DateTime? Rented_From { get; set; }
        public DateTime? Rented_Till { get; set; }
    }
}