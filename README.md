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

No contexto do projeto desenvolvido, o padrão Iterator foi aplicado com o objetivo de
organizar o acesso a uma coleção de dados, como listas de produtos, usuários ou
registros. A principal intenção foi separar a forma de acesso aos dados da forma
como eles estão armazenados, promovendo maior clareza estrutural.

A implementação seguiu o conceito fundamental do padrão, no qual a coleção atua
como um repositório de dados, enquanto o Iterator é responsável por percorrer
esses elementos de maneira sequencial. Essa abordagem permitiu que o sistema
acessasse os dados sem depender diretamente da estrutura interna da coleção.

<img src="exemplo iterator.png">
De forma ilustrativa, pode-se comparar a coleção a uma caixa que contém diversos
itens, enquanto o Iterator atua como o responsável por retirar esses itens um a um,
na ordem correta. Essa analogia ajuda a compreender como o padrão abstrai a
complexidade da estrutura de dados.

Outro ponto importante é que o uso do Iterator permitiu maior organização do
código, evitando que a lógica de navegação fosse repetida em diferentes partes do
sistema. Isso contribuiu para a redução de erros e para a melhoria da legibilidade.

Portanto, a implementação do padrão Iterator no projeto demonstrou, na prática,
como sua utilização pode contribuir para o desenvolvimento de sistemas mais
organizados, flexíveis e de fácil manutenção.


##  Análise Crítica

O padrão Iterator é uma forma muito organizada de acessar coleções de dados.

Mas, sendo bem direto, ele nem sempre é necessário. Em sistemas simples, pode acabar complicando mais do que ajudando, porque adiciona mais classes e estrutura ao código.

Além disso, linguagens como C# já possuem soluções prontas, como o `foreach`, que fazem esse trabalho de forma mais simples. Por isso, usar o Iterator manualmente pode ser redundante em alguns casos.

Por outro lado, em sistemas maiores e mais complexos, o Iterator faz bastante diferença. Ele ajuda a deixar o código mais organizado, facilita a manutenção e permite que o sistema evolua sem causar muitos problemas.

**Resumindo**

- Em sistemas simples → pode ser desnecessário  
- Em sistemas complexos → é muito útil
-  

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

 ## Exemplos Reais no Mercado

O padrão Iterator é muito usado na prática, mesmo que às vezes a gente nem perceba.

Isso acontece porque muitas linguagens e frameworks já implementam esse padrão internamente, facilitando a vida do desenvolvedor.

   **Onde ele aparece no dia a dia:**

- **C# / .NET**  
  Usado nas interfaces `IEnumerable` e `IEnumerator`, além do comando `foreach`, que percorre coleções automaticamente.

- **Java**  
  A interface `Iterator` permite percorrer listas, conjuntos e outras coleções da biblioteca padrão.

- **Bancos de dados**  
  Cursores são usados para percorrer resultados de consultas linha por linha, funcionando de forma parecida com um Iterator.

- **APIs e sistemas web**  
  Muitas APIs retornam listas de dados que são percorridas utilizando esse conceito.

- **Sistemas empresariais (ERP, e-commerce, etc.)**  
  Muito usado para percorrer listas de produtos, clientes, pedidos e outros registros.

**Exemplo prático:**

Imagine um sistema de e-commerce com uma lista de produtos.

Para exibir os produtos na tela, o sistema precisa percorrer essa lista.  
Mesmo sem perceber, o desenvolvedor está usando o conceito de Iterator (por exemplo, com um `foreach`).

Em outras palavras, sempre que você percorre uma coleção de dados de forma organizada e sem precisar saber como ela funciona por dentro, você está usando o padrão Iterator, mesmo que de forma indireta.


### Conclusão

O padrão Iterator ajuda a deixar o sistema mais organizado, flexível e fácil de manter, sendo muito utilizado no desenvolvimento de software profissional.





## Referências Biograficas

- GAMMA, Erich; HELM, Richard; JOHNSON, Ralph; VLISSIDES, John.  
  *Design Patterns: Elements of Reusable Object-Oriented Software*. Boston: Addison-Wesley, 1995.

- GAMMA, Erich; HELM, Richard; JOHNSON, Ralph; VLISSIDES, John.  
  *Padrões de Projeto: Soluções Reutilizáveis de Software Orientado a Objetos*. Porto Alegre: Bookman, 2000.

- FREEMAN, Eric; FREEMAN, Elisabeth.  
  *Head First Design Patterns*. Sebastopol: O’Reilly Media, 2004.

- MARTIN, Robert C.  
  *Clean Code: A Handbook of Agile Software Craftsmanship*. Upper Saddle River: Prentice Hall, 2008.

- MICROSOFT.  
  *IEnumerable Interface*. Disponível em:  
  https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable  
  Acesso em: 22 mar. 2026.

- MICROSOFT.  
  *IEnumerator Interface*. Disponível em:  
  https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerator  
  Acesso em: 22 mar. 2026.

- ORACLE.  
  *Interface Iterator (Java Platform SE)*. Disponível em:  
  https://docs.oracle.com/javase/8/docs/api/java/util/Iterator.html  
  Acesso em: 22 mar. 2026.

- REFACTORING GURU.  
  *Iterator Design Pattern*. Disponível em:  
  https://refactoring.guru/design-patterns/iterator  
  Acesso em: 22 mar. 2026.
