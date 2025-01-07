using ASP2.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP2.Controllers
{
    public class AnimalsController : Controller
    {
        public IActionResult Details(string name)
        {
            var animal = AnimalRepository.Animals.FirstOrDefault(a => a.Name == name);
            if (animal == null) return NotFound();
            return View(animal);
        }
    }
}
