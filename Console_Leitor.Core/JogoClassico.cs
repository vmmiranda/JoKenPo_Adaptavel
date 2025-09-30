using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Leitor.Core
{
    public class JogoClassico
    {
        public enum Escolha { Pedra, Papel, Tesoura };

        public string DeterminarVencedor(Escolha jogador1, Escolha jogador2)
        {
            if (jogador1 == jogador2)
            {
                return "Empate";
            }
            else if ((jogador1 == Escolha.Pedra && jogador2 == Escolha.Tesoura) ||
                    (jogador1 == Escolha.Papel && jogador2 == Escolha.Pedra) ||
                    (jogador1 == Escolha.Tesoura && jogador2 == Escolha.Papel))
            {
                return "Jogador 1 vence";
            }
            else
            {
                return "Jogador 2 vence";
            }
        }
    }
}
