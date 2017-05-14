using Microsoft.AspNetCore.Mvc;

namespace ColFinanzas.Controllers
{
    public class EmpresaController : Controller
    {
        public IActionResult InicioEmpresa()
        {
            return View();
        }

    }
}