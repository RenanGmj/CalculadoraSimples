
# Calculadora Simples em C#

Este é um projeto de uma calculadora de console em C# que permite realizar operações matemáticas básicas: soma, subtração, multiplicação e divisão. O projeto foi desenvolvido com uma arquitetura modular, incluindo classes específicas para a conversão de entrada e cálculo das operações, garantindo uma manipulação adequada de valores numéricos fornecidos pelo usuário.

## Funcionalidades

- **Conversão de Entrada**: A classe `ConversaoDeEntrada` transforma a entrada do usuário em um valor numérico, validando o tipo de dado inserido e evitando erros de execução.
- **Operações Matemáticas**: A classe `Calculadora` realiza operações de soma, subtração, multiplicação e divisão com base no tipo de operação fornecido pelo usuário.
- **Tratamento de Exceções**: O programa inclui tratamento de exceções para entradas inválidas, como divisão por zero e operações não reconhecidas.

## Estrutura do Projeto

### Classes Principais

- `Calculadora`: Responsável por executar as operações matemáticas. O método `Calculalar` recebe o tipo de operação e dois números como entrada, retornando o resultado da operação.
- `ConversaoDeEntrada`: Converte entradas do usuário para um tipo numérico (`double`). Se a entrada não for numérica, lança uma exceção informativa.

### Exemplo de Uso

Ao rodar o programa, ele solicita que o usuário insira dois números e o tipo de operação a ser realizada (soma, subtração, multiplicação ou divisão). A operação é executada com base nos valores fornecidos, e o resultado é exibido no console.

```plaintext
Digite o primeiro numero:
5
Digite o segundo numero:
3
Digite a operação que deseja realizar:
+
Resultado: 8
```

## Tecnologias Utilizadas
- Linguagem: C#
- Framework de Teste: NUnit
