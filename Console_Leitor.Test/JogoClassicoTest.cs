using Console_Leitor.Core;
using static Console_Leitor.Core.JogoClassico;

namespace Console_Leitor.Test
{
    public class JogoClassicoTest
    {
        [Theory]
        [InlineData(Escolha.Pedra, Escolha.Pedra, "Empate")]
        [InlineData(Escolha.Tesoura, Escolha.Tesoura, "Empate")]
        [InlineData(Escolha.Papel, Escolha.Papel, "Empate")]
        [InlineData(Escolha.Pedra, Escolha.Tesoura, "Jogador 1 vence")]
        [InlineData(Escolha.Tesoura, Escolha.Papel, "Jogador 1 vence")]
        [InlineData(Escolha.Papel, Escolha.Pedra, "Jogador 1 vence")]
        [InlineData(Escolha.Pedra, Escolha.Papel, "Jogador 2 vence")]
        [InlineData(Escolha.Tesoura, Escolha.Pedra, "Jogador 2 vence")]
        [InlineData(Escolha.Papel, Escolha.Tesoura, "Jogador 2 vence")]
        public void DeterminarVencedor_DeveEscolherVencedorCorreto(Escolha jogador1, Escolha jogador2,string resultado)
        {
            var loader = new JogoClassico();
            var resultadoEsperado = loader.DeterminarVencedor(jogador1, jogador2);
            Assert.Equal(resultado, resultadoEsperado);
        }
    }
}