using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectIA_renting_Cars.Models
{
    public class User
    {
        public int Id { get; set; }
        public string SSN { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Balance { get; set; }
        public DateTime Date_Of_Birht { get; set; }
        public User_Type UserType { get; set; }
        public category Prefered_Category { get; set; }
    }
}