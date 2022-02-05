using System;
namespace RPG
{
    public class CampoDeserto : ICampoBatalha
    {
    
        public Personagem Vantagem { get; set; }
        public bool EhPlayer1 = true;

        public CampoDeserto()
        {
            Vantagem = null;
        }

        public void Batalhar(Personagem player1, Personagem player2)
        {
            if (EhPlayer1)
            {
                Console.WriteLine($@"A vida do {player2.Nome } vida {player2.Vida } antes do ataque");

                player1.Atacar(player2, 0);
            
                if (player2.Vida < 10)
                    player2.Vida = 0;
                EhPlayer1 = false;
                Console.WriteLine($@"A vida do {player2.Nome } é de {player2.Vida }");
            }
            else
            {
                Console.WriteLine($@"A vida do {player1.Nome } vida {player1.Vida } antes do ataque");
                player2.Atacar(player1, 0);
                if (player1.Vida < 10)
                    player1.Vida = 0;
                EhPlayer1 = true;
                Console.WriteLine($@"A vida do {player1.Nome } é de {player1.Vida }");
            }
           
        }
    }
}
