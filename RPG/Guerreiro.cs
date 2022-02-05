using System;
namespace RPG
{
    public class Guerreiro : Personagem
    {
        public Guerreiro(double vida, string nome, string sexo, string cor) : base(vida, nome, sexo, cor)
        {
        }

        public override void Atacar(Personagem vitima, double ganho)
        {
            vitima.Vida -= (vitima.Vida * 0.5) + (vitima.Vida * ganho);
        }

        public override void Correr()
        {
            Console.WriteLine($"O personagem { Nome } esta correndo a 10 km/h");
        }

        public override void Defender()
        {
            Console.WriteLine($"O personagem { Nome } esta se defendendo");
            Vida += (Vida * 0.1);
        }
    }
}
