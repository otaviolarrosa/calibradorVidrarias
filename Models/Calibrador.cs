namespace app.Models
{
    public class Calibrador
    {
        public double? PesoCopoCheioPrimeiraPesagem { get; set; }
        public double? PesoCopoCheioSegundaPesagem { get; set; }
        public double? PesoCopoCheioTerceiraPesagem { get; set; }
                     
        public double? PesoCopoVazioPrimeiraPesagem { get; set; }
        public double? PesoCopoVazioSegundaPesagem { get; set; }
        public double? PesoCopoVazioTerceiraPesagem { get; set; }
                     
        public double? PrimeiraMassaDaAgua { get; set; }
        public double? SegundaMassaDaAgua { get; set; }
        public double? TerceiraMassaDaAgua { get; set; }

        public int? Temperatura { get; set; }
    }
}