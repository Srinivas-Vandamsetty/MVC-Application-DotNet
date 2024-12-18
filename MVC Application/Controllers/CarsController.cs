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
                new Car { Make = "Toyota", Model = "Innova", Year = 2023, Price = 1500000 },
                new Car { Make = "Honda", Model = "City", Year = 2024, Price = 1100000 },
                new Car { Make = "Tata", Model = "Nexon", Year = 2022, Price = 1300000 },
                new Car { Make = "Suzuki", Model = "Swift", Year = 2023, Price = 800000 },
                new Car { Make = "Mahindra", Model = "Thar", Year = 2024, Price = 2400000 }
            };

            // Passing the model to the view
            return View(cars);
        }
    }
}
