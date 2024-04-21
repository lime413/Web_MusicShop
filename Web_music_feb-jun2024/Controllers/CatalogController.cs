using Microsoft.AspNetCore.Mvc;
using Web_music_feb_jun2024.Models;

namespace Web_music_feb_jun2024.Controllers
{
    public class CatalogController : Controller
    {
        private MusicContext db;
        public CatalogController(MusicContext context)
        {
            db = context;
        }
        public IActionResult Catalog()
        {
            return View();
        }
    }
}
