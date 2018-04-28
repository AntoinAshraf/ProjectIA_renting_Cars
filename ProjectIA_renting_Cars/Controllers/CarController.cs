
using ProjectIA_renting_Cars.Models;
using ProjectIA_renting_Cars.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectIA_renting_Cars.Controllers
{
    public class CarController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Car
        public ActionResult Index()
        {
            return View();
        }




        public ActionResult CarSearchPage( int? id )
        {

            var CC = getCarCategory();
            if (id == null)
            {


                return View(CC);
            }
            else
            {
                IEnumerable<Car> CarSearched = db.Cars.Where(c => c.CategoryID == id).ToList();
                CarCategory carBrand = new CarCategory
                {
                    Car = CarSearched,
                    Category=db.Categories.Where(c =>c.Id == id)

                };
                return View(carBrand);
            }
        }

         public CarCategory getCarCategory ()
        {
            
            var car = db.Cars.ToList();
            var Category = db.Categories.ToList();
            
            CarCategory CC = new CarCategory
            {
                Category = Category,
                Car = car
            };

            return (CC);
        }


        public ActionResult Details( int id )
        {
            var car = db.Cars.SingleOrDefault(c => c.Id == id);

            return View(car);
        }

        //public Car Search(int id)
        //{
        //    var CC = getCarCategory();
        //    foreach (var item in CC.Car)
        //    {
        //        if (item.CategoryID == id)
        //        {
        //            return (item);
        //        }
        //        else
        //        {
        //            return ();
        //        }
        //    }
        //}


    }
}