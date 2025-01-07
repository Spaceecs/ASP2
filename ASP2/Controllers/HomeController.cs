using System.Diagnostics;
using ASP2.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var animals = AnimalRepository.Animals;
            return View(animals);
        }
    }
}
