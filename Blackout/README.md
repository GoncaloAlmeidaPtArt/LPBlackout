# Projeto final: Blackout
<p>Diciplina: Linguagens de Programação I [Videojogos]
<p>Instituição: Universidade Lusófona Lisboa
<p>Professores: Afonso Oliveira, Rafael Jos´e, Nuno Fachada
<p>Ano letivo: 2025/2026
<p>Alunos: Goncalo Almeida a22504073 / Isis Rocha a22504772


## Divisão de trabalho: 
#### Goncalo Almeida
- Protótipo do projeto em script único com a lógica principal do jogo para ser aplicado em modelo MVC. Ainda sem randomização das celulas.

- Ajuste do protótipo para o coincidir em modelo MVC script entre as classes Controller, PrototypeView e Board.

- Modificação do projeto para aplicar a randomização de celulas de acordo com a dificuldade. 

- Documentação das linhas de Código do projeto. 

#### Isis Rocha

- Implementação da biblioteca Spectre.Console no projeto. 

- Criação da classe Cells e ajuste do projeto para implementar a classe adequadamente. 

- Pequenos ajustes no projeto para para auxiliar a transição para modelo MVC e melhorar a lógica e visibilidade. 

- Criação e escrita do ficheiro README.md

- Acrécimo da documentação das linhas de código restantes.

## Repositório do Git:
LPBlackout:
[Link para o repositório](https://github.com/GoncaloAlmeidaPtArt/LPBlackout.git)

## Arquitetura da solução e Algorítimos: 

## Diagrama UML de classes: 
```mermaid
classDiagram
class IView{
    <<Interface>>   
}
Program --> Controller
Board *--> Cells
Controller --> Board
Controller --> PrototypeView
PrototypeView ..|> IView
PrototypeView ..> Cells
```

## Bibliotecas ultilizadas e Referências: 
### Bibliotecas: 
Spectre.Console
### Referências, IA ou Código de terceiros: 
<p>Ultilizado a ferramenta de IA Copilot para automatizar tarefas não relacionadas 
com a realização da lógica do script. Estas sendo: Mudar o nome de variáveis automaticamente por todo o código, escrever strings para outputs de teste e auxiliar na escrita dos comentários.
</p>

