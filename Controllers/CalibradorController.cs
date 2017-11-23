using System.Linq;
using Microsoft.AspNetCore.Mvc;
using app.Models;

namespace app.Controllers
{
    public class CalibradorController : Controller
    {
        public IActionResult Index()
        {
            var dados = new app.Models.Calibrador();
            return View("Index",dados);
        }

        [HttpPost]
        public IActionResult Calcular(app.Models.Calibrador dados)
        {
            return View("Resultado", new calibradorVidrarias.Business.Calibrador().Calcular(dados));
        }
    }
}