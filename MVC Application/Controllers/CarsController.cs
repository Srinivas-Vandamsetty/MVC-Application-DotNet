using Microsoft.AspNetCore.Mvc;

namespace MVC_Application.Controllers
{
    public class CarsController : Controller
    {
        public IActionResult Index()
        {
            string[] carsNames = { "Toyota", "Audi", "Tata", "BMW" };
            var cars = new List<string>(carsNames);
            return View(cars);
        }
    }
}
