using Microsoft.AspNetCore.Mvc;
using MVC6Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC6Demo.Controllers
{
    public class CarController : Controller
    {
        static List<Car> Cars = new List<Car>() {
            new Car(){ Code = 1, Color = "Black"},
            new Car(){ Code = 2, Color = "Red"},
            new Car(){ Code = 3, Color = "Orange"},
        };

        public IActionResult Index()
        {
            return View(Cars);
        }

        //this action require data from user 
        //should use concret class
        //input params should be filled by query string (GET) or request content (POST) 
        public IActionResult GetCar(Car car)
        {
            return Content(car.Accelerate());
        }

        //if params is service action depends on it to work
        //should not depend on concret class rather interface
        //method injection
        public IActionResult Move([FromServices] IVichel vichel, [FromServices]IVichel vichel1)
        {
            return Content(vichel.GetHashCode().ToString()+"-"+vichel1.GetHashCode().ToString());
        }

        public IActionResult Move2([FromServices] IVichel vichel, [FromServices] IVichel vichel1)
        {
            return Content(vichel.GetHashCode().ToString() + "-" + vichel1.GetHashCode().ToString());
        }
    }
}
