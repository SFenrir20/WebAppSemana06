using Microsoft.AspNetCore.Mvc;
using WebAppSemana06.Services;

namespace WebAppSemana06.Controllers
{
    public class ProveedorController : Controller
    {
        private readonly IProveedor _proveedor;
        public ProveedorController(IProveedor objPro)
        {
            _proveedor = objPro;
        }
        [Route("Proveedor/Info/{id}")]
        public IActionResult InfoProveedor(string id)
        {
            return View(_proveedor.GettProveedor(id));
        }
    }
}
