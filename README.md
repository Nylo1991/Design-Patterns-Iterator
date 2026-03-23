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

O padrão de projeto **Iterator** é um padrão comportamental que tem como objetivo fornecer uma forma de acessar sequencialmente os elementos de uma coleção sem expor sua estrutura interna.

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
