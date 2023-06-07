using Microsoft.AspNetCore.Mvc;
using WebAppSemana06.Models;
using WebAppSemana06.Services;

namespace WebAppSemana06.Controllers
{
    public class TemporalVentaController : Controller
    {
        private readonly ITemporalVenta _temporalVenta;
        public TemporalVentaController(ITemporalVenta temporal)
        {
            _temporalVenta = temporal;
        }
        public IActionResult Index( string txtcodigo,
                                    string txtdescripcion,
                                    string txtprecio,
                                    string txtcantidad)
        {
            TemporalVenta obj = new TemporalVenta();
            obj.codigo = txtcodigo; 
            obj.descripcion = txtdescripcion;
            obj.precio = double.Parse(txtprecio);
            obj.cantidad = int.Parse(txtcantidad);

            _temporalVenta.add(obj);
            return RedirectToAction("Index", "Producto");
        }
        public IActionResult VerCarrito() 
        {
            return View(_temporalVenta.GetAllTemporarySales());
        }
    }
}
