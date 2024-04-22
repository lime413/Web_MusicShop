using Microsoft.AspNetCore.Mvc;

namespace Web_music_feb_jun2024.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
