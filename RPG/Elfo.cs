using System;
namespace RPG
{
    public class Elfo : Personagem
    {
        public Elfo(double vida, string nome, string sexo, string cor) : base(vida, nome, sexo, cor)
        {
        }

        public override void Defender()
        {
            Vida += (Vida * 0.05);
        }
    }
}
