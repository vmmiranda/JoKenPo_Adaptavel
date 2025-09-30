using Console_Leitor.Core;

internal class Program
{
    private static void Main(string[] args)
    {
        var jogoClassico = new JogoClassico();
        Console.WriteLine(jogoClassico.DeterminarVencedor(JogoClassico.Escolha.Papel ,JogoClassico.Escolha.Pedra ));//Jogador 1 vence
        Console.WriteLine(jogoClassico.DeterminarVencedor(JogoClassico.Escolha.Papel, JogoClassico.Escolha.Tesoura));//Jogador 2 vence


        string defRegrasJogo = @"{
                                    ""Pedra"" :[""Tesoura"", ""Spock""],
                                    ""Tesoura"" :[""Papel"", ""Lagarto""],
                                    ""Papel"" :[""Pedra"", ""Spock""],
                                    ""Spock"" :[""Pedra"", ""Tesoura""],
                                    ""Lagarto"" :[""Papel"", ""Spock""]

                                }";

        ICarregadorRegras loader = new CarregadorRegras(defRegrasJogo);
        var regrasCarregadas = loader.DeterminarRegras().GetAwaiter().GetResult();



        var novoJogo = new NovoJoKenPo(regrasCarregadas);

        Console.WriteLine(novoJogo.DeterminarVencedor("Papel", "Spock"));//Jogador 1 vence
        Console.WriteLine(novoJogo.DeterminarVencedor("Spock", "Lagarto"));//Jogador 2 vence

    }
}