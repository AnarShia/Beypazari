using Beypazari.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using AdanaSuck;

namespace Beypazari.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Soyad soyad = new Soyad();
            var surname = soyad.Soyadım();
            return View(surname);
        }

        public IActionResult Privacy()
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