using IntegradorFront.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IntegradorFront.Controllers
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
            return View();
        }

        public IActionResult InstalacionesDeportivas()
        {
            return View();
        }
        public IActionResult BuscaTuReserva()
        {
            return View();
        }
        public IActionResult AcercaDeNosotros()
        {
            return View();
        }

        public IActionResult Login()
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
