using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web_music_feb_jun2024.Models;

namespace Web_music_feb_jun2024.Controllers
{
    public class AccountController : Controller
    {
        private MusicContext db;
        public AccountController(MusicContext context)
        {
            db = context;
        }
        public IActionResult Login()
        {
            return View();
        }
        public async Task<IActionResult> Register([Bind("Id,Nickname,Email,Password,Role,Cart")] User user)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(user);
                await db.SaveChangesAsync();
                return RedirectToAction("/Client/Home");
            }
            return View(user);
        }
    }
}
