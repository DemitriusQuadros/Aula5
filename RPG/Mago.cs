using System;
namespace RPG
{
    public class Mago : Personagem
    {
        public Mago(double vida, string nome, string sexo, string cor) : base(vida, nome, sexo, cor)
        {
        }

        public override void Atacar(Personagem vitima, double ganho)
        {
            vitima.Vida -= (vitima.Vida * 0.4) + (vitima.Vida * ganho);
        }

        public override void Defender()
        {
            Vida += (Vida * 0.05);
        }
    }
}
