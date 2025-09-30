using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Leitor.Core
{
    public class NovoJoKenPo
    {
        private readonly RegrasJogo _regras;

        public NovoJoKenPo(RegrasJogo regras)
        {
            _regras = regras;
        }

        public string DeterminarVencedor(string jogador1 , string jogador2)
        {
            if(jogador1 == jogador2)
            {
                return "Empate";
            }
            else if(_regras.VenceContra.ContainsKey(jogador1) && _regras.VenceContra[jogador1].Any(v=>v.ToLower() == jogador2.ToLower()))
            {
                return "Jogador 1 vence";
            }
            else if (_regras.VenceContra.ContainsKey(jogador2) && _regras.VenceContra[jogador2].Any(v => v.ToLower() == jogador1.ToLower()))
            {
                return "Jogador 2 vence";
            }
            else
            {
                return "Entrada inválida";
            }
        }
    }
}
