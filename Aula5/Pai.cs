using System;
namespace Aula5
{
    public class Pai
    {
        public string CorDoCabelo { get; set; }
        public string CorDosOlhos { get; set; }
        public string TipoDeCabelo { get; set; }
        public string CorDePele { get; set; }

        public Pai(string corDoCabelo, string corDosOlhos, string tipoDeCabelo, string corDePele)
        {
            CorDoCabelo = corDoCabelo;
            CorDosOlhos = corDosOlhos;
            TipoDeCabelo = tipoDeCabelo;
            CorDePele = corDePele;
        }
    }
}
