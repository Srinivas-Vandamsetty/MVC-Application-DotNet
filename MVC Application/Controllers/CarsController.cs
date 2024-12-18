using Microsoft.AspNetCore.Mvc;
using MVC_Application.Models;

namespace MVC_Application.Controllers
{
    // Base route for the controller
    [Route("car")]
    public class CarController : Controller
    {
        // Route for the Details action
        [Route("details")]
        public IActionResult Details()
        {
            // Simulating a list of cars fetched from the database
            var cars = new List<Car>
            {
                new Car { Make = "Toyota", Model = "Camry", Year = 2021, Price = 25000 },
                new Car { Make = "Honda", Model = "Civic", Year = 2020, Price = 22000 },
                new Car { Make = "Ford", Model = "Mustang", Year = 2022, Price = 35000 },
                new Car { Make = "Chevrolet", Model = "Malibu", Year = 2021, Price = 24000 },
                new Car { Make = "BMW", Model = "3 Series", Year = 2021, Price = 40000 }
            };

            // Passing the model to the view
            return View(cars);
        }
    }
}
