using System;

namespace Aula5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var filho = new Filho("Rosa", "Roxo", "Black Power", "Verde");

            Console.WriteLine(filho.CorDoCabelo);
            Console.WriteLine(filho.CorDosOlhos);
            Console.WriteLine(filho.TipoDeCabelo);
            Console.WriteLine(filho.CorDePele);

        }

        public static void Revisao2()
        {
            var opcao = "";
            Alarme alarme = new Alarme(new Controle());

            while (opcao != "4")
            {
                Console.Clear();
                Console.WriteLine($@"
                1- Clicar no controle
                2 - disparar o alarme
                3 - play mary
                4 - sair");
                opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        alarme.Controle.Clicar(alarme);
                        break;
                    case "2":
                        alarme.Disparar();
                        break;
                    case "3":
                        break;
                    default:
                        Console.WriteLine("Opcao invalida");
                        break;
                }
                Console.ReadKey();
            }
        }

        public static void Revisao1()
        {
            string texto = "Hello World!";
            Console.WriteLine(texto);

            var arr = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("-----------------");

            foreach (int numero in arr)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("If e Switch");


            var idade = 20;

            if (idade < 18)
            {
                Console.WriteLine("Adolescente");
            }
            else
            {
                Console.WriteLine("Adulto");
            }

            switch (idade)
            {
                case 18:
                    Console.WriteLine("Fazer carteira de motorista");
                    break;
                case 19:
                    Console.WriteLine("Inscrever-se na faculdade");
                    break;
                case 20:
                    Console.WriteLine("Ta na hora de trabalhar");
                    break;
                default:
                    break;
            }
        }
    }
}
