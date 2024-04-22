using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Web_music_feb_jun2024.Models;
using Web_music_feb_jun2024.ViewModels;

namespace Web_music_feb_jun2024.Controllers
{
    public class ClientController : Controller
    {
        private readonly ILogger<ClientController> _logger;

        public ClientController(ILogger<ClientController> logger)
        {
            _logger = logger;
        }

        public IActionResult Home()
        {
            return View();
        }

        public IActionResult Shops()
        {
            return View();
        }

        public IActionResult Card()
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
