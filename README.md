# Console_Leitor

## Descrição

Este projeto implementa duas versões do jogo Jokenpo (Pedra, Papel, Tesoura):

1. **Jokenpo Clássico**: Regras tradicionais, onde cada escolha vence ou perde para outra de forma fixa.
2. **Novo Jokenpo Customizável**: Permite definir novas regras do jogo dinamicamente através de uma string JSON, possibilitando variações como "Pedra, Papel, Tesoura, Lagarto, Spock".

---

## Estrutura do Projeto

- `Console_Leitor.Core`
  - `JogoClassico.cs`: Implementa o Jokenpo tradicional.
  - `NovoJoKenPo.cs`: Implementa o Jokenpo customizável.
  - `CarregadorRegras.cs`: Carrega e interpreta as regras do jogo a partir de uma string JSON.
  - `Program.cs`: Exemplo de uso das duas versões do jogo.
- `Console_Leitor.Test`
  - Testes unitários para ambas as versões.

---

## Jokenpo Clássico

### Uso
