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
            dados.PrimeiraMassaDaAgua = ObterMassaDaAgua(dados.PesoCopoVazioPrimeiraPesagem, dados.PesoCopoCheioPrimeiraPesagem);
            dados.SegundaMassaDaAgua = ObterMassaDaAgua(dados.PesoCopoVazioSegundaPesagem, dados.PesoCopoCheioSegundaPesagem);
            dados.TerceiraMassaDaAgua = ObterMassaDaAgua(dados.PesoCopoVazioPrimeiraPesagem, dados.PesoCopoCheioTerceiraPesagem);
            var densidade = new Models.Constantes().tabelaDensidadeAgua.Where(x => x.Temperatura == dados.Temperatura).FirstOrDefault().Densidade;

            var volumeReal1 = CalcularVolumeReal(dados.PrimeiraMassaDaAgua, densidade);
            var volumeReal2 = CalcularVolumeReal(dados.SegundaMassaDaAgua, densidade);
            var volumeReal3 = CalcularVolumeReal(dados.TerceiraMassaDaAgua, densidade);
            var mediaVolumeReal = ((volumeReal1 + volumeReal2 + volumeReal3) / 3);
            var resultado = new Resultado
            {
                DesvioDeMedia = mediaVolumeReal.ToString().Replace('.',','),
                PrimeiroDesvioDeMedia = volumeReal1.ToString().Replace('.', ','),
                SegundoDesvioDeMedia = volumeReal2.ToString().Replace('.', ','),
                TerceiroDesvioDeMedia = volumeReal3.ToString().Replace('.', ',')
            };
            return View("Resultado", resultado);
        }

        public double CalcularVolumeReal(double? massaAgua, double? densidade)
        {
            return massaAgua.GetValueOrDefault() / densidade.GetValueOrDefault();
        }

        public double ObterMassaDaAgua(double? copoVazio, double? copoCheio)
        {
            return copoCheio.GetValueOrDefault() - copoVazio.GetValueOrDefault();
        }
    }
}