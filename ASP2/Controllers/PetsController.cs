using Microsoft.AspNetCore.Mvc;

namespace ASP2.Controllers
{
    public class PetsController : Controller
    {
        public IActionResult Dog()
        {
            return Content("Собака: Це вірний і дружній друг, який любить гуляти та грати.");
        }

        public IActionResult Cat()
        {
            return Content("Кішка: Незалежна, граційна та іноді примхлива, але завжди мила.");
        }

        public IActionResult Parrot()
        {
            return Content("Папуга: Барвистий і говіркий птах, який приносить багато радості.");
        }
    }
}
