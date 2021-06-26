using Layer.Aplication.Helper;
using Layer.Aplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;

namespace Layer.Aplication.Controllers
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

        public IActionResult Nuevo()
        {
            return View();
        }

        [HttpGet("Listar")]
        public List<ProductoModel> Listar()
        {
            return ProductoAccessData.Listar();
        }

        [HttpPost("Filtrar")]
        public List<ProductoModel> Filtrar([FromBody] ProductoModel entidad)
        {
            return ProductoAccessData.Filtrar(entidad);
        }


        [HttpPost("Grabar")]
        public string Registrar([FromBody] ProductoModel entidad)
        {
            return ProductoAccessData.Registrar(entidad);
        }

        [HttpPut("Actualizar")]
        public string Modificar([FromBody] ProductoModel entidad)
        {
            return ProductoAccessData.Modificar(entidad);
        }

        [HttpDelete("Eliminar/{id}")]
        public string Eliminar(int id)
        {
            return ProductoAccessData.Eliminar(id);
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
