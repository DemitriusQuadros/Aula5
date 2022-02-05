using System;
namespace RPG
{
    public abstract class Personagem 
    {
        public double Vida { get; set; }
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public string Cor { get; set; }


        public Personagem(double vida, string nome, string sexo, string cor)
        {
            Vida = vida;
            Nome = nome;
            Sexo = sexo;
            Cor = cor;
        }

        public virtual void Atacar(Personagem vitima, double ganho)
        {
            vitima.Vida -= ((vitima.Vida * 0.2) + (vitima.Vida * ganho));
        }

        public virtual void Correr()
        {
            Console.WriteLine($"O personagem { Nome} esta correndo a 20 km/h");
        }

        public abstract void Defender();
    }
}
