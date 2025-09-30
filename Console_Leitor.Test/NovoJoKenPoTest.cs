using Console_Leitor.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Leitor.Test
{
    
    public class NovoJoKenPoTest
    {
        private readonly NovoJoKenPo _loaderJogo;

        string defRegrasJogo = @"{
                                    ""Pedra"" :[""Tesoura"", ""Spock""],
                                    ""Tesoura"" :[""Papel"", ""Lagarto""],
                                    ""Papel"" :[""Pedra"", ""Spock""],
                                    ""Spock"" :[""Pedra"", ""Tesoura""],
                                    ""Lagarto"" :[""Papel"", ""Spock""]

                                }";

        public NovoJoKenPoTest()
        {
            ICarregadorRegras loaderRegras = new CarregadorRegras(defRegrasJogo);
            var regras = loaderRegras.DeterminarRegras().GetAwaiter().GetResult();

            _loaderJogo = new NovoJoKenPo(regras);
        }

        [Fact]
        void DeterminarVencedor_LagartoVence()
        {
            string resultadoEsperado = "Jogador 1 vence";
            var resultado = _loaderJogo.DeterminarVencedor("Lagarto", "Spock");
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        void DeterminarVencedor_PapelVence()
        {
            string resultadoEsperado = "Jogador 2 vence";
            var resultado = _loaderJogo.DeterminarVencedor( "Spock","Papel");
            Assert.Equal(resultadoEsperado, resultado);
        }
    }
}
