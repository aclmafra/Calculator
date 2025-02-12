# Projeto Calculadora

Este projeto é uma aplicação de calculadora básica 
desenvolvida em C# utilizando o framework .NET 8.0 e 
Windows Forms. A calculadora permite a realização de operações
matemáticas simples com uma interface amigável. 

 

O primeiro feito foi desenvolver o design da calculadora com o
Windows Forms, criando os componentes, como os botões dos
números e operações, assim como o campo de texto onde aparece
os valores digitados e os resultados das respectivas
operações. 

<p align="center">
  <img src="images/CalculatorProject.jpg" width="300" />
</p>

<p align="center">
  <em>(Representação visual da calculadora feita com 
  o Windows Forms)</em>
</p>
 


Posteriormente, é desenvolvido a lógica de cada componente,
definindo o que o programa retorna a cada interação.  

A lógica das operações foi implementada utilizando o evento
Click do botão correspondente, onde o valor atual é armazenado
em uma variável e a operação é definida, posteriormente sendo
realizada quando o próximo número é digitado. 

## Próximos Passos
- Corrigir Bug nas Operações: Resolver o problema que ocorre
ao pressionar os botões de operação antes de inserir qualquer
valor ou ao pressionar repetidamente os botõesde operação. 
- Expandir Funcionalidades: Adicionar novas funcionalidades à
calculadora, como operações de potência, porcentagem e outras
operações matemáticas avançadas.
- Tratar Exceção de Divisão por Zero: Implementar um tratamento
de exceção para evitar erros quando a divisão por zero for
efetuada. 

## Tecnologias Usadas:
- C#
- .NET Framework 8.0
- Windows Forms

## Como executar:
 Este projeto pode ser executado diretamente pelo 
 Visual Studio ou via terminal com o comando “dotnet run”,
 caso o .NET 8.0 SDK esteja instalado.

 ## Detalhes técnicos/Boas Práticas:
- Alinhamento do Campo de Texto: O campo de texto é alinhado
 à direita para seguir o padrão visual das calculadoras
 tradicionais.
- Campo de Texto Somente Leitura: A propriedade ReadOnly do
campo de texto é ativada, permitindo entrada de dados apenas
via botões da interface, evitando entrada direta pelo 
teclado.
- Posicionamento Centralizado: O design da aplicação é
configurado para iniciar centralizado na tela, proporcionando
uma experiência de usuário mais agradável.
- Nomeação Descritiva de Componentes: Todos os componentes da
interface são nomeados de forma descritiva, facilitando a
manutenção e o desenvolvimento contínuo do projeto. 

## Observações Finais:
Este projeto é uma ótima introdução ao desenvolvimento de 
aplicações de desktop com C# e Windows Forms. Pretendo 
continuar aprimorando-o com novas funcionalidades e correções. 

