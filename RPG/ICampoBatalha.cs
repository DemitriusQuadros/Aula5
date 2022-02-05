using System;
namespace RPG
{
    public interface ICampoBatalha
    {
        Personagem Vantagem { get; set; }

        void Batalhar(Personagem player1, Personagem player2);
    }
}
