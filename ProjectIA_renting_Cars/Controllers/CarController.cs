using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectIA_renting_Cars.Controllers
{
    public class CarController : Controller
    {
        // GET: Car
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RegesterCar()
        {
            return View();
        }

        public ActionResult EditCar()
        {
            return View();
        }
    }
}