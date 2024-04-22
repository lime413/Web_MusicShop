using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Web_music_feb_jun2024.Models;
using Web_music_feb_jun2024.ViewModels;

namespace Web_music_feb_jun2024.Controllers
{
    public class HelpController : Controller
    {
        private readonly ILogger<HelpController> _logger;

        public HelpController(ILogger<HelpController> logger)
        {
            _logger = logger;
        }

        public IActionResult WhereOrder()
        {
            return View();
        }

        public IActionResult Hotline()
        {
            return View();
        }

        public IActionResult Guarantee()
        {
            return View();
        }

        public IActionResult ServiceCentres()
        {
            return View();
        }

        public IActionResult ExchangeAndReturn()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
