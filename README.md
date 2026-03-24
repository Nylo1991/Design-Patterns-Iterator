# Pesquisa e Desenvolvimento Design Patterns

## Iterator

SENAI AFONSO GRECO 

CURSO TÉCNICO EM DESENVOLVIMENTO DE SISTEMAS






NOME: Danilo Silva Santos


PROFESSOR: Frederico Martins Aguiar


PESQUISA E DESENVOLVIMENTO: Design Patterns Iterator





NOVA LIMA - MG 2026

#  Relatório Técnico – Padrão de Projeto Iterator

##  Definição do Padrão

O padrão de projeto Iterator é um padrão comportamental que tem como objetivo fornecer uma forma de acessar sequencialmente os elementos de uma coleção sem expor sua estrutura interna.

Ele permite percorrer diferentes tipos de coleções de maneira uniforme, desacoplando o código que realiza a iteração da estrutura de dados utilizada.

##  Problema que o Padrão Resolve

Em sistemas de software, é comum trabalhar com coleções de dados, como listas, filas ou árvores. Sem o uso do padrão Iterator, o código que percorre essas estruturas fica diretamente acoplado à sua implementação interna.

Isso gera alguns problemas:
- Dificuldade de manutenção do código  
- Baixa flexibilidade  
- Dependência forte da estrutura de dados  
- Complexidade ao lidar com múltiplas coleções diferentes  

O padrão Iterator resolve esse problema ao fornecer uma interface comum para percorrer elementos, independentemente da estrutura da coleção.

 ## Estrutura do Padrão

O padrão Iterator é composto por alguns elementos principais:

- **Iterator (Interface):** Define os métodos para percorrer os elementos (ex: `Next()`, `HasNext()`).
  
- **ConcreteIterator (Iterador Concreto):** Implementa a interface do Iterator e mantém o controle da posição atual na coleção.
  
- **Aggregate (Coleção/Agregador):** Interface que define a criação do iterador.
  
- **ConcreteAggregate (Coleção Concreta):** Implementa a interface do agregador e retorna um iterador apropriado.

  ## Participantes 

O padrão Iterator é composto por diferentes participantes, cada um com responsabilidades bem definidas dentro da arquitetura:

**Iterator (Interface)**

Define a interface responsável pela navegação na coleção.  
Estabelece os métodos que permitem percorrer os elementos de forma sequencial, sem expor a estrutura interna.

**ConcreteIterator (Iterador Concreto):**

Implementa a interface `Iterator` e é responsável por manter o estado atual da iteração.

**Aggregate (Agregador / Coleção Abstrata):**

Define a interface para criação de objetos iteradores.

**ConcreteAggregate (Coleção Concreta):**

Implementa a interface `Aggregate` e representa a coleção real de dados.

## Justificativa da Escolha

Eu escolhi o padrão Iterator, porque pelo que deu pra pesquisar ele facilita muito a forma de acessar os dados no sistema.

Normalmente, quando a se trabalha com listas ou outras coleções, o código acaba ficando muito preso à forma como esses dados estão organizados. Isso dificulta quando precisamos mudar alguma coisa depois.

Com o Iterator, isso muda. Ele permite que a gente percorra os dados sem precisar se preocupar com como eles estão armazenados.

**Resumindo**
- Ele separa o jeito de acessar os dados da forma como eles estão guardados  
- Deixa o código mais organizado  
- Facilita fazer mudanças no futuro  
- Funciona da mesma forma para diferentes tipos de coleção  

##  Implementação no Projeto

##  Análise Crítica

## Comparação com Abordagens sem o Padrão

**Sem usar o Iterator**

Quando não usamos o padrão Iterator, o código acessa a coleção diretamente.

 Exemplo:  
Acessar uma lista usando índices diretamente (`lista[i]`)

 **Quando usamos o Iterator?:**

Com o padrão Iterator, o acesso aos dados é feito por meio de um objeto responsável pela navegação.
 
 Exemplo:  
Usar um iterador ou `foreach` para percorrer a coleção

**Em Resumo**

| Sem Iterator | Com Iterator |
|-------------|-------------|
| Código acoplado à estrutura | Código desacoplado |
| Difícil manutenção | Fácil manutenção |
| Pouca flexibilidade | Alta flexibilidade |
| Acesso direto aos dados | Acesso controlado |

## Vantagens

O uso do padrão Iterator traz vários benefícios para o desenvolvimento no sistema:

- **Reduz o acoplamento**  
  O código que percorre os dados não depende da estrutura interna da coleção.

- **Facilita a manutenção**  
  Alterações na estrutura da coleção não afetam diretamente o restante do sistema.

- **Permite diferentes formas de navegação**  
  É possível percorrer os dados de várias maneiras (normal, reverso, filtrado, etc.).

- **Padroniza o acesso às coleções**  
  Diferentes estruturas podem ser acessadas da mesma forma.

- **Código mais organizado**  
  A lógica de navegação fica separada, deixando o sistema mais limpo.

- **Maior reutilização de código**  
  A mesma lógica de iteração pode ser usada em diferentes partes do sistema.

- **Facilita a evolução do sistema**  
  Novas formas de percorrer os dados podem ser adicionadas sem alterar o código existente.

## Desvantagens

Apesar das vantagens, o padrão Iterator também possui alguns pontos negativos:

- **Aumenta a quantidade de classes**  
  É necessário criar mais interfaces e implementações, o que pode deixar o projeto maior.

- **Pode ser desnecessário em sistemas simples**  
  Em casos básicos, usar um `foreach` já resolve o problema de forma mais simples.

- **Pode impactar levemente a performance**  
  O uso de objetos extras pode gerar uma pequena sobrecarga.

- **Nem sempre traz benefício real**  
  Em aplicações pequenas, o custo pode ser maior que o benefício.

- **Pode gerar código mais verboso**  
  Comparado a soluções simples, pode exigir mais linhas de código.
