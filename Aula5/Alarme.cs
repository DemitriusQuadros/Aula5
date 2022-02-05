using System;
using System.IO;
using System.Media;

namespace Aula5
{
    public class Alarme
    {
        public Controle Controle { get; set; }
        public bool Ativo { get; set; }

        public Alarme(Controle controle)
        {
            Ativo = false;
            Controle = controle;
        }

        public void Disparar()
        {
            Console.WriteLine("iuiuiuiuiui tan tan tan papapapapa");
        }

        public void Ativar()
        {
            Ativo = true;
            //if (File.Exists(@"/Users/demitriusruanquadros/Projects/Aula5/Aula5/Car Horn 01.mp3"))
            //{
            //    SoundPlayer player = new SoundPlayer(@"/Users/demitriusruanquadros/Projects/Aula5/Aula5/Car Horn 01.mp3");
            //    player.PlaySync();
            //}
            Console.Beep(400, 100);
            Console.WriteLine("Emitindo som de ativado");

        }

        public void Desativar()
        {
            Ativo = false;
            Console.WriteLine("Emitindo som de desativado");
        }
    }
}
