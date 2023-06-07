using Microsoft.AspNetCore.Mvc;
using WebAppSemana06.Models;
using WebAppSemana06.Services;

namespace WebAppSemana06.Controllers
{
    public class DistritoController : Controller
    {
        private readonly IDistrito _distrito;
        public DistritoController(IDistrito distrito)
        {
            _distrito= distrito;    
        }
        public IActionResult Index()
        {
            return View(_distrito.GetAllDistritos());
        }
        public IActionResult Nuevo() 
        {
            return View();  
        }
        public IActionResult Grabar(TbDistrito obj)
        {
            _distrito.add(obj);
            return RedirectToAction("Index");       
        }
        [Route("Distrito/Eliminar/{codigo}")]
        public IActionResult Eliminar(string codigo) 
        {
            _distrito.remove(codigo);
            return RedirectToAction("Index");   
        }
    }
}
