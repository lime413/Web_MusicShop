using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public async Task<IActionResult> Catalog(int Id = 0)
        {
            var model = new CatalogViewModel();
            var instrumentClasses = await db.InstrumentClasses.ToListAsync();
            var instruments = await db.Instruments.ToListAsync();
            model.instrumentClasses = instrumentClasses;
            if (Id > 0) model.instruments = instruments.Where(x => x.Class.Id == Id).Take(9);
            else model.instruments = instruments.Take(9);
            return View(model);
        }
        public IActionResult Product()
        {
            return View();
        }
    }
}
