using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using appventas.Models;

namespace appventas.Controllers
{
    public class ProductoController : Controller
    {
        private readonly ILogger<ProductoController> _logger;

        public ProductoController(ILogger<ProductoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["Message"] = "";
            return View();
        }

        [HttpPost]
        public IActionResult MiMetodoExecute(Producto objProducto)
        {
            Double result = 0.0;
            String message ="";
            
                result = (objProducto.Precio * objProducto.Cantidad)*1.18;
                message ="El resultado es " + result;
            
            
            ViewData["Message"] = message;
            return View("Index");
        }

    }
}
