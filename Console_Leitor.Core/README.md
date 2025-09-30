# Console_Leitor

## Descri��o

Este projeto implementa duas vers�es do jogo Jokenpo (Pedra, Papel, Tesoura):

1. **Jokenpo Cl�ssico**: Regras tradicionais, onde cada escolha vence ou perde para outra de forma fixa.
2. **Novo Jokenpo Customiz�vel**: Permite definir novas regras do jogo dinamicamente atrav�s de uma string JSON, possibilitando varia��es como "Pedra, Papel, Tesoura, Lagarto, Spock".

---

## Estrutura do Projeto

- `Console_Leitor.Core`
  - `JogoClassico.cs`: Implementa o Jokenpo tradicional.
  - `NovoJoKenPo.cs`: Implementa o Jokenpo customiz�vel.
  - `CarregadorRegras.cs`: Carrega e interpreta as regras do jogo a partir de uma string JSON.
  - `Program.cs`: Exemplo de uso das duas vers�es do jogo.
- `Console_Leitor.Test`
  - Testes unit�rios para ambas as vers�es.

---

## Jokenpo Cl�ssico

### Uso
