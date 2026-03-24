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

**Isso significa que:**
- O código fica dependente da estrutura (lista, array, etc.)  
- Qualquer mudança na coleção pode quebrar o código  
- Fica mais difícil reutilizar  
- O sistema fica menos organizado  

 Exemplo:  
Acessar uma lista usando índices diretamente (`lista[i]`)

 ### Quando usamos o Iterator

Com o padrão Iterator, o acesso aos dados é feito por meio de um objeto responsável pela navegação.

**Isso traz vantagens como:**
- O código não depende da estrutura da coleção  
- É mais fácil fazer mudanças no sistema  
- O código fica mais organizado  
- Permite diferentes formas de percorrer os dados  

 Exemplo:  
Usar um iterador ou `foreach` para percorrer a coleção

**Em Resumo**

| Sem Iterator | Com Iterator |
|-------------|-------------|
| Código acoplado à estrutura | Código desacoplado |
| Difícil manutenção | Fácil manutenção |
| Pouca flexibilidade | Alta flexibilidade |
| Acesso direto aos dados | Acesso controlado |
