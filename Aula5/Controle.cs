using System;
namespace Aula5
{
    public class Controle
    {

        public void Clicar(Alarme alarme)
        {
            if (alarme.Ativo)
                alarme.Desativar();
            else
                alarme.Ativar();

        }
    }
}
