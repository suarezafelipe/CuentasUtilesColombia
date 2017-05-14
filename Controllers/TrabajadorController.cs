using Microsoft.AspNetCore.Mvc;

namespace ColFinanzas.Controllers
{
    public class TrabajadorController : Controller
    {
        public IActionResult InicioTrabajador()
        {
            return View();
        }

        public IActionResult Independiente()
        {
            return View();
        }

        public IActionResult Empleado()
        {
            return View();
        }
    }
}