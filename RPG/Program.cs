using System;

namespace RPG
{
    class MainClass
    {
        public static bool EhPlayer1 = true;

        public static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao game RPG da melhor turma de C#");

            Personagem player1 = SelecionarPersonagem();
            Personagem player2 = SelecionarPersonagem();

            ICampoBatalha campoBatalha = SelecionarCampoBatalha();

            Console.Clear();

            while(player1.Vida > 0 && player2.Vida > 0)
            {
                campoBatalha.Batalhar(player1, player2);
            }

            if (player1.Vida > 0)
            {
                EscreverVencedor(player1);
            } else
            {
                EscreverVencedor(player2);   
            }
            Console.WriteLine("Fim de jogo");
            Console.ReadKey();
        }

        private static ICampoBatalha SelecionarCampoBatalha()
        {
            Console.WriteLine("Selecione 1 - Mistico, 2 - Floresta, 3 - Deserto");
            var opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    return new CampoMistico();
                case "2":
                    return new CampoFloresta();
                default:
                    return new CampoDeserto();
            }
        }

        private static void EscreverVencedor(Personagem player)
        {

            Console.WriteLine($@"
                PARABÉS VOCE VENCEU
                Nome: { player.Nome }
                Sexo: { player.Sexo }
                Cor: { player.Cor }
                Vida: { player.Vida }
                Tipo: { player.GetType().ToString() } 
                

            ");
        }
        
        public static Personagem SelecionarPersonagem()
        {

            Console.WriteLine("Escolha um personagem 1 - Guerreiro, 2- Elfo e 3 - Mago");
            var opcao = Console.ReadLine();

            Console.WriteLine("Informe um nome");
            var nome = Console.ReadLine();

            Console.WriteLine("Informe o sexo do personagem");
            var sexo = Console.ReadLine();

            Console.WriteLine("Informe a cor do personagem");
            var cor = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    return new Guerreiro(new Random().Next(1000),nome, sexo, cor);
                case "2":
                    return new Elfo(new Random().Next(1000), nome, sexo, cor);
                default:
                    return new Mago(new Random().Next(1000), nome, sexo, cor);
            }
        }
    }
}
