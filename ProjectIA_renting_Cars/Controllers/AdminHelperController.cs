using ProjectIA_renting_Cars.Models;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ProjectIA_renting_Cars.Controllers
{
    public class AdminHelperController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();

        public IEnumerable<category> category { get; set; }

        public AdminHelperController()
        {
            category = db.Categories.ToList();
        }

        [HttpGet]
        public ActionResult AddCar()
        {
 
            CarCateogryViewModel carCategory = new CarCateogryViewModel
            {
                Category = category  
                //Category = getCateogry()
            };

            return View(carCategory);
        }


        [HttpPost]
        public ActionResult AddCar(CarCateogryViewModel carCategory)
        {
            if (!ModelState.IsValid)
            {
                carCategory.Category = category;
               // carCategory.Category = getCateogry();
                return View("AddCar",carCategory);
            }
            
            db.Cars.Add(carCategory.car);
            db.SaveChanges();
            return RedirectToAction("Index","Home");
        }
        [HttpGet]
        public ActionResult EditCar(int id)
        {
             var car = db.Cars.Single(c => c.Id == id);
             var category = db.Categories.ToList();
            CarCateogryViewModel carCategory = new CarCateogryViewModel
            {
               Category=category,
               car=car 
            };
            return View(carCategory);
        }
        [HttpPost]
        public ActionResult EditCar(CarCateogryViewModel carCategory)
        {
            if (!ModelState.IsValid)
            {
                   var category = db.Categories.ToList();
                   carCategory.Category = category;
                return View("EditCar", carCategory);
            }

            var carDB = db.Cars.Single(c => c.Id == carCategory.car.Id);
            carDB.Car_Name = carCategory.car.Car_Name;
            carDB.Car_Model = carCategory.car.Car_Model;
            carDB.Car_Color = carCategory.car.Car_Color;
            carDB.Price = carCategory.car.Price;
            carDB.Category = carCategory.car.Category;

            db.SaveChanges();
            return RedirectToAction("Index", "Home"); 
        }
        [HttpGet]
        public ActionResult DeleteCar(int id)
        {
            var car = db.Cars.Single(c => c.Id == id);
            db.Cars.Remove(car);
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
         
      
        public IEnumerable<Car> getCars()
        {
            var cars = db.Cars.ToList();
            return cars;
        }

        [HttpGet]
        public ActionResult AdminHomePage()
        {
            var cars = getCars();
            return View(cars);
        }
       
        public IEnumerable<category> getCateogry()
        {
            List<category> Category = new List<category>
            {
                new category {Id =1 ,Category_Name="Hundai" },
                new category {Id =2,Category_Name="Kia" },
                new category {Id =3 ,Category_Name="Skoda" }
            };
            return Category;
        }
    }
}