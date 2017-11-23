using System.Linq;
using app.Models;

namespace calibradorVidrarias.Business
{
    public class Calibrador
    {
        internal Resultado Calcular(app.Models.Calibrador dados)
        {
            dados.PrimeiraMassaDaAgua = ObterMassaDaAgua(dados.PesoCopoVazioPrimeiraPesagem, dados.PesoCopoCheioPrimeiraPesagem);
            dados.SegundaMassaDaAgua = ObterMassaDaAgua(dados.PesoCopoVazioSegundaPesagem, dados.PesoCopoCheioSegundaPesagem);
            dados.TerceiraMassaDaAgua = ObterMassaDaAgua(dados.PesoCopoVazioPrimeiraPesagem, dados.PesoCopoCheioTerceiraPesagem);
            var densidade = new app.Models.Constantes().tabelaDensidadeAgua.Where(x => x.Temperatura == dados.Temperatura).FirstOrDefault().Densidade;

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
            return resultado;
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