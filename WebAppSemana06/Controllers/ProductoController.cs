using Microsoft.AspNetCore.Mvc;
using WebAppSemana06.Services;

namespace WebAppSemana06.Controllers
{
    public class ProductoController : Controller
    {
        private readonly IProducto _producto;
        public ProductoController(IProducto producto) 
        {
            _producto= producto;    
        }

        public IActionResult Index()
        {
            return View(_producto.GetAllProducts());
        }
        [Route("Producto/Comprar/{codigo}")]
        public IActionResult Comprar(string codigo)
        {
            var objObtenido = _producto.GetProduct(codigo);
            return View(objObtenido);
        }
    }
}
