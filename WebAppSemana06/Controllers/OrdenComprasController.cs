using Microsoft.AspNetCore.Mvc;
using WebAppSemana06.Services;

namespace WebAppSemana06.Controllers
{

    public class OrdenComprasController : Controller
    {
        private readonly IOrdenDeCompra _ordenCompra;

        public OrdenComprasController(IOrdenDeCompra objOrden)
        { 
            _ordenCompra = objOrden;
        }

        public IActionResult VallOrdenCompra()
        {
            return View(_ordenCompra.GetAll());
        }

        [Route("OrdenCompra/VerOrdenCompra/{cod}")]
        public IActionResult VerOrdenCompra(string cod)
        {
            return View(_ordenCompra.GetOrdenCompra(cod));
        }
    }
}
