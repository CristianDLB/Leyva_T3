using Leyva_T3.DB;
using Leyva_T3.Models;
using Leyva_T3.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Leyva_T3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        //private readonly IHomeRepositorio homeRepositorio;

        //public HomeController(IHomeRepositorio homeRepositorio)
        //{
        //    this.homeRepositorio = homeRepositorio;
        //}

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var cuenta = DbEntities.cuentas;
            return View(cuenta);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Crear()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Crear(Cuenta cuenta)
        {
            DbEntities.cuentas.Add(cuenta);
            return View();
        }

        [HttpGet]
        public IActionResult AddMascota(int id)
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