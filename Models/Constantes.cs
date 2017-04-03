using System.Collections.Generic;

namespace app.Models
{
    public class Constantes
    {
        public List<DesidadeAgua> tabelaDensidadeAgua { get; set; }

        public Constantes()
        {
            tabelaDensidadeAgua = new List<DesidadeAgua>
            {
                new DesidadeAgua
                {
                    Temperatura = 0,
                    Densidade = 0.99987
                },
                new DesidadeAgua
                {
                    Temperatura = 1,
                    Densidade = 0.99993
                },
                new DesidadeAgua
                {
                    Temperatura = 2,
                    Densidade = 0.99997
                },
                new DesidadeAgua
                {
                    Temperatura = 3,
                    Densidade = 0.99999
                },
                new DesidadeAgua
                {
                    Temperatura = 4,
                    Densidade = 1.00000
                },
                new DesidadeAgua
                {
                    Temperatura = 5,
                    Densidade = 0.99999
                },
                new DesidadeAgua
                {
                    Temperatura = 6,
                    Densidade = 0.99997
                },
                new DesidadeAgua
                {
                    Temperatura = 7,
                    Densidade = 0.99993
                },
                new DesidadeAgua
                {
                    Temperatura = 8,
                    Densidade = 0.99988
                },
                new DesidadeAgua
                {
                    Temperatura = 9,
                    Densidade = 0.99981
                },
                new DesidadeAgua
                {
                    Temperatura = 10,
                    Densidade = 0.99973
                },
                new DesidadeAgua
                {
                    Temperatura = 11,
                    Densidade = 0.99963
                },
                new DesidadeAgua
                {
                    Temperatura = 12,
                    Densidade = 0.99952
                },
                new DesidadeAgua
                {
                    Temperatura = 13,
                    Densidade = 0.99940
                },
                new DesidadeAgua
                {
                    Temperatura = 14,
                    Densidade = 0.00927
                },
                new DesidadeAgua
                {
                    Temperatura = 15,
                    Densidade = 0.99913
                },
                new DesidadeAgua
                {
                    Temperatura = 16,
                    Densidade = 0.99897
                },
                new DesidadeAgua
                {
                    Temperatura = 17,
                    Densidade = 0.99880
                },
                new DesidadeAgua
                {
                    Temperatura = 18,
                    Densidade = 0.99862
                },
                new DesidadeAgua
                {
                    Temperatura = 19,
                    Densidade = 0.99843
                },
                new DesidadeAgua
                {
                    Temperatura = 20,
                    Densidade = 0.99823
                },
                new DesidadeAgua
                {
                    Temperatura = 21,
                    Densidade = 0.99702
                },
                new DesidadeAgua
                {
                    Temperatura = 22,
                    Densidade = 0.99780
                },
                new DesidadeAgua
                {
                    Temperatura = 23,
                    Densidade = 0.99757
                },
                new DesidadeAgua
                {
                    Temperatura = 24,
                    Densidade = 0.99732
                },
                new DesidadeAgua
                {
                    Temperatura = 25,
                    Densidade = 0.99707
                },
                new DesidadeAgua
                {
                    Temperatura = 26,
                    Densidade = 0.99681 
                },
                new DesidadeAgua
                {
                    Temperatura = 27,
                    Densidade = 0.99652
                },
                new DesidadeAgua
                {
                    Temperatura = 28,
                    Densidade = 0.99622
                },
                new DesidadeAgua
                {
                    Temperatura = 29,
                    Densidade = 0.99592
                },
                new DesidadeAgua
                {
                    Temperatura = 30,
                    Densidade = 0.99561
                },
            };
        }


    }
    public class DesidadeAgua
    {
        public int Temperatura { get; set; }
        public double Densidade { get; set; }
    }
}
