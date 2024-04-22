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
            model.Id = Id;
            model.instrumentClasses = await db.InstrumentClasses.ToListAsync();
            if (Id > 0) model.instruments = await db.Instruments.Where(x => x.Class.Id == Id).Take(9).ToListAsync();
            else model.instruments = await db.Instruments.Take(9).ToListAsync();
            return View(model);
        }
        public async Task<IActionResult> Product(string? Articul = null)
        {
            var model = new ProductViewModel();
            model.instrumentClasses = await db.InstrumentClasses.ToListAsync();
            model.instrument = await db.Instruments.FirstOrDefaultAsync(x => x.Articul.Equals(Articul));
            return View(model);
        }
    }
}
