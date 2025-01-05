using Microsoft.AspNetCore.Mvc;

namespace ASP2.Controllers
{
    public class WildAnimalsController : Controller
    {
        public IActionResult Lion()
        {
            return Content("Лев: Король савани, відомий своєю силою та граційністю.");
        }

        public IActionResult Wolf()
        {
            return Content("Вовк: Хижак, що живе в зграях. Символ свободи та дикої природи.");
        }

        public IActionResult Eagle()
        {
            return Content("Орел: Гордий птах, що ширяє високо в небі та символізує силу.");
        }
    }
}
