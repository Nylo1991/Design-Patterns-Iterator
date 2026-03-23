# Pesquisa e Desenvolvimento Design Patterns

##Iterator

SENAI AFONSO GRECO 

CURSO TÉCNICO EM DESENVOLVIMENTO DE SISTEMAS






NOME: Danilo Silva Santos


PROFESSOR: Frederico Martins Aguiar


PESQUISA E DESENVOLVIMENTO: Design Patterns Iterator





NOVA LIMA - MG 2026

**1. Definição do Padrão**

O padrão de projeto Iterator é um padrão comportamental que tem como objetivo fornecer uma forma de acessar sequencialmente os elementos de uma coleção sem expor sua estrutura interna. Ele permite percorrer diferentes tipos de coleções de maneira uniforme, desacoplando o código que realiza a iteração da estrutura de dados utilizada.

<img src="scrum-framework.jpg">

Shutterstock
Características Principais da Estrutura: A engrenagem do Scrum funciona através da combinação de três elementos centrais: Papéis, Eventos e Artefatos.
A Equipa Scrum (Papéis): É multifuncional e auto-gerida. Não há hierarquias tradicionais.
Product Owner (Dono do Produto): Representa o cliente. É responsável por maximizar o valor do produto, gerindo e priorizando a lista de requisitos.
Scrum Master: O facilitador. Remove impedimentos da equipa, garante que o Scrum é compreendido e aplicado corretamente, e protege a equipa de interrupções externas.
Developers (Programadores/Equipe Técnica): Os profissionais que de fato constroem o produto, comprometendo-se a entregar um incremento de software a funcionar a cada ciclo.
Os Ciclos (Eventos): Todo o trabalho ocorre dentro de blocos de tempo fixos (timeboxes).
Sprint: O ciclo principal, que dura de 1 a 4 semanas. É onde o trabalho acontece.
Sprint Planning: Planeamento do que será feito na Sprint atual.
Daily Scrum: Reunião diária (máx. 15 minutos) para a equipe técnica sincronizar o trabalho das próximas 24 horas.
Sprint Review: Reunião no final da Sprint para mostrar o software  funcionando aos stakeholders (interessados).
Sprint Retrospective: Reunião focada na melhoria contínua dos processos da própria equipe.
Os Artefatos: * Product Backlog: A lista de tudo o que é necessário para o produto.
Sprint Backlog: A lista de tarefas selecionadas para a Sprint atual.
Incremento: A soma de todos os itens do Backlog concluídos durante a Sprint (o software pronto a usar).

**2. Tipos de Projetos Mais Adequados**

O Scrum não é uma "bala de prata" que serve para tudo. Ele brilha em ambientes complexos e de alta incerteza.
·         Projetos com Requisitos Mutáveis: Se o cliente não sabe exatamente o que quer desde o início, ou se o mercado muda rapidamente, o Scrum é ideal. A cada Sprint, o rumo pode ser ajustado.
·         Desenvolvimento de Software Inovador e Startups: Criação de novos aplicativos, plataformas web SaaS (Software as a Service) ou MVPs (Minimum Viable Products). Nestes casos, o tempo de lançamento no mercado (Time-to-Market) é crucial, e o Scrum permite lançar versões básicas rapidamente e melhorá-las interativamente.
·         Modernização de Sistemas Legados: Quando se está a reescrever um sistema antigo, a equipe pode ir substituindo e entregando módulos aos poucos usando Sprints, em vez de tentar mudar tudo de uma vez.
Onde NÃO usar: Projetos simples, previsíveis e com escopo fechado (como a construção de um muro padrão ou a montagem de peças numa fábrica) não beneficiam do Scrum, pois a sobrecarga de reuniões (Daily, Review, Retrospective) não compensa.

**3. Ferramentas Associadas**

Para que a transparência e a colaboração ocorram (especialmente em equipes remotas ou híbridas), o mercado utiliza ferramentas digitais para gerir o Scrum. Elas ajudam a visualizar o fluxo de trabalho, geralmente utilizando quadros Kanban (Colunas: "A Fazer", "Em Progresso", "Concluído").
·         Jira Software (Atlassian): É a ferramenta líder de mercado em empresas de médio e grande porte. É altamente customizável, permite gerir backlogs gigantescos, planear Sprints, rastrear bugs (falhas) e gerar relatórios automáticos (como o Burndown Chart, que mostra a velocidade da equipe).
·         Trello: Muito visual e intuitivo, baseado em quadros. É excelente para startups, projetos de faculdade ou equipes de software menores. Não tem relatórios avançados como o Jira, mas a sua simplicidade é o seu maior trunfo.
·         Azure DevOps (Azure Boards): Muito forte em empresas que utilizam o ecossistema Microsoft. Tem a vantagem de integrar o planejamento das Sprints diretamente com o repositório de código (Git) e com a esteira de testes automatizados.
·         Confluence / Notion: Ferramentas associadas para documentação. Como o Scrum diz que "software a funcionar é mais importante que documentação abrangente", estas ferramentas servem para criar documentação técnica ágil, como regras de negócio e arquitetura, de forma colaborativa.

### Quais são as vantagens do Scrum?

Seja no desenvolvimento de software ou no setor médico, o Scrum facilita a execução do trabalho por meio de experimentação contínua e feedback constante, aprimorando a qualidade do produto. Embora essa seja apenas uma das qualidades, existem muitas outras vantagens nesse método. Vejamos algumas delas:

<img src="vantagens.png">

**Abordagem adaptável**

A abordagem Scrum baseia-se principalmente na adaptabilidade do projeto. Se a sua organização não possui objetivos predefinidos ou requisitos identificáveis ​​no início do projeto, o Scrum é uma metodologia extremamente útil. Opera principalmente em Sprints, onde as mudanças necessárias em uma Sprint podem ser implementadas em outra. Portanto, permite alterar qualquer projeto sem impactar os resultados.

**Altamente eficiente**

O Guia do Product Owner do Scrum enfatiza que o tamanho da equipe Scrum é tipicamente pequeno, garantindo que cada membro assuma total responsabilidade pelo seu trabalho, o que leva a uma melhoria na qualidade. Além disso, com o trabalho distribuído entre as equipes, a identificação oportuna de gargalos do produto e a implementação rápida de soluções tornam-se uma prática padrão.

**Promove a criatividade**

Durante o processo de desenvolvimento do produto, os projetos são monitorados continuamente. Isso permite que a equipe identifique áreas para melhoria e otimize o fluxo de trabalho. Consequentemente, são realizadas sessões de brainstorming com os membros da equipe para estimular ideias criativas e executar tarefas rotineiras.

**Reduz o custo do projeto**

Ao minimizar a documentação excessiva, planos de ação e histórias de usuário, o Scrum pode reduzir os custos indiretos em comparação com os métodos convencionais. Esses planos fornecem um roteiro claro e conciso para os desenvolvedores, permitindo que eles se concentrem nas tarefas atuais em vez de perder tempo com burocracia.

**Fornece feedback regular**

As reuniões diárias de Scrum facilitam a atualização do progresso, a identificação de impedimentos e a colaboração da equipe para manter o alinhamento com as metas da Sprint. Além disso, esse feedback diário ajuda o projeto a funcionar sem problemas a longo prazo.

**Transparente**

Como a metodologia envolve fornecer feedback regular e garantir a participação de cada membro da equipe, até mesmo pequenas modificações feitas no projeto (em qualquer nível) ficam visíveis para todos os membros da equipe. Dessa forma, constrói-se confiança e garante-se a entrega de produtos de melhor qualidade, promovendo ainda mais a transparência.

### Quais são as desvantagens do Scrum?

Embora a metodologia Scrum possua inúmeras vantagens, muitos profissionais e equipes ainda preferem outras abordagens para a gestão de projetos. É importante conhecer as limitações do Scrum para saber se essa abordagem é a mais adequada para a realidade da sua organização. Algumas das principais desvantagens incluem:

<img src="desvantagens.png">


**1. Requer indivíduos experientes**

Normalmente, as organizações precisam de funcionários altamente qualificados e experientes para conduzir projetos Scrum. Se a equipe não tiver experiência prévia com métodos ágeis, poderá ser muito difícil gerenciar o fluxo de trabalho. Além disso, o treinamento e a curva de aprendizado dos funcionários podem aumentar os custos iniciais.

**2. Expansão do escopo**

Os projetos Scrum seguem uma abordagem iterativa e flexível, mantendo-se fiéis aos cronogramas ou marcos predeterminados com base no escopo e nas entregas acordadas. No entanto, se o escopo não for bem controlado ou se algum membro fundamental da equipe se desligar durante o processo, o risco de falha do projeto aumenta. Por isso, é crucial utilizar técnicas eficazes de estimativa para lidar com incertezas e manter a estabilidade.

**3. Ineficaz com equipes grandes**

O framework Scrum não foi projetado para lidar eficientemente com projetos excessivamente grandes ou com equipes muito numerosas. Gerenciar dezenas de pessoas dentro das cerimônias do Scrum (como as reuniões diárias) pode ser desafiador e frequentemente leva a falhas de comunicação e dificuldades de coordenação. Em escalas maiores, os projetos podem se tornar excessivamente complexos de implementar.

**4. Altera o ambiente de trabalho padronizado**

Trabalhar com a hierarquia organizacional tradicional usando Scrum pode gerar conflitos. O Scrum exige colaboração horizontal entre o Product Owner, o Scrum Master e a Equipe de Desenvolvimento. Isso rompe com as estruturas hierárquicas clássicas de "chefe e subordinado" para promover o trabalho em equipe, o que pode causar resistência em culturas corporativas mais rígidas.

**5. Requer testes rigorosos**

O Scrum é um processo ágil focado na entrega iterativa de valor de negócio por meio de inspeção, adaptação e colaboração contínuas. Como as equipes precisam entregar um incremento de software (ou produto) funcional a cada *sprint*, isso exige uma rotina de testes extremamente rigorosa e frequente para garantir a qualidade enquanto a equipe aprimora continuamente seu trabalho.


## Onde aplicar o Scrum

Embora o Scrum tenha surgido inicialmente no desenvolvimento de software, atualmente essa metodologia pode ser aplicada em diversos tipos de projetos. Seu uso não se limita apenas à área de tecnologia, sendo também adotado por equipes de marketing, vendas, design, recursos humanos e até setores administrativos. Isso ocorre porque o Scrum contribui para a organização das atividades, melhora a comunicação entre os membros da equipe e possibilita alcançar resultados de forma mais eficiente.

O Scrum é especialmente recomendado para projetos mais complexos, que envolvem diferentes participantes e apresentam mudanças frequentes ao longo do processo. Sua estrutura é baseada em ciclos curtos de trabalho, chamados de sprints, que permitem acompanhar o progresso das atividades de forma contínua. Dessa forma, a equipe consegue identificar problemas rapidamente, realizar ajustes quando necessário e manter todos os envolvidos alinhados com os objetivos do projeto.

Outra característica importante do Scrum é a sua flexibilidade. Quando surge a necessidade de modificar ou adaptar o escopo do projeto, a metodologia permite reorganizar prioridades sem comprometer a entrega final. Essa capacidade de adaptação é essencial em ambientes dinâmicos, nos quais as demandas e as condições do mercado podem mudar rapidamente.


### Comparação do Scrum com outras metodologias

O Scrum é um framework de gestão ágil que organiza o trabalho em ciclos fixos chamados Sprints, que normalmente possuem duração entre uma e quatro semanas. Durante esses ciclos, a equipe trabalha para entregar pequenas partes funcionais do produto, permitindo que o projeto evolua de forma incremental. Além disso, o Scrum incentiva a colaboração constante entre os membros da equipe e a adaptação contínua às necessidades do cliente.

Diferente de outras abordagens de gerenciamento de projetos, o Scrum possui uma estrutura bem definida, com papéis específicos como Product Owner, Scrum Master e Equipe de Desenvolvimento, além de eventos obrigatórios que organizam o processo de trabalho. Essa estrutura facilita o acompanhamento do progresso do projeto e garante maior transparência no desenvolvimento.

A seguir, é apresentada uma comparação entre o Scrum e algumas das principais metodologias e abordagens utilizadas no mercado.

**Scrum vs. Cascata (Waterfall)**

Uma das principais diferenças entre o Scrum e o modelo Cascata está na forma como os projetos são organizados e executados.

No modelo Cascata, o desenvolvimento ocorre de forma linear e sequencial. As etapas seguem uma ordem fixa, normalmente composta por levantamento de requisitos, design, implementação e testes. Nesse modelo, todo o planejamento é realizado no início do projeto, o que dificulta a realização de mudanças posteriormente.

Já no Scrum, o desenvolvimento acontece de forma iterativa e incremental. O projeto é dividido em pequenas etapas chamadas sprints, permitindo que o escopo seja ajustado ao longo do desenvolvimento com base no feedback recebido. Isso reduz os riscos de falhas e aumenta as chances de entregar um produto alinhado com as expectativas do cliente.

**Scrum vs. Kanban**

Embora ambos façam parte das metodologias ágeis, o Scrum e o Kanban possuem diferenças importantes em relação à forma de organizar o trabalho.

No Scrum, o trabalho é planejado dentro de ciclos fixos chamados sprints. Durante uma sprint, as tarefas definidas no planejamento devem ser concluídas sem alterações significativas até o final do ciclo. Essa abordagem oferece maior previsibilidade nas entregas e organização do trabalho.

Já o Kanban trabalha com um fluxo contínuo de tarefas, sem a existência de ciclos fixos. As atividades são organizadas em um quadro visual e são realizadas conforme a capacidade da equipe. Esse modelo utiliza o conceito de WIP (Work in Progress) para limitar a quantidade de tarefas em andamento e evitar sobrecarga de trabalho. O Kanban é muito utilizado em equipes de suporte, manutenção e ambientes onde as demandas mudam constantemente.

**Scrum vs. XP (Extreme Programming)**

O Extreme Programming (XP) é outra abordagem ágil que pode ser utilizada em conjunto com o Scrum. Entretanto, cada uma dessas metodologias possui um foco diferente.

O Scrum é voltado principalmente para gestão e organização do projeto, definindo papéis, reuniões e artefatos como o Product Backlog e o Sprint Backlog.

Já o XP é focado em práticas técnicas de desenvolvimento de software, com o objetivo de melhorar a qualidade do código e reduzir erros. Entre as práticas mais conhecidas do XP estão a programação em par (Pair Programming), o desenvolvimento orientado a testes (Test-Driven Development – TDD) e a integração contínua.

**Scrum vs. Lean**

O Lean não é apenas uma metodologia de desenvolvimento, mas sim uma filosofia de gestão que tem como objetivo principal eliminar desperdícios e otimizar processos dentro de uma organização.

Enquanto o Lean busca melhorar todo o sistema de entrega de valor, o Scrum aplica muitos desses princípios dentro de uma estrutura de equipe específica. No Scrum, o foco está na entrega rápida de incrementos de produto, permitindo validar resultados e realizar melhorias constantes com base no feedback recebido.

                                                                                                                             
                                                                                                                             
**Uma comparação entre diferentes metodologias de gerenciamento de projetos, destacando as principais diferenças entre Scrum e outras abordagens amplamente utilizadas. Cada metodologia possui características próprias e pode ser aplicada de acordo com o tipo de projeto, nível de complexidade e necessidade de adaptação às mudanças.**

| Comparações | Scrum | Cascata (Waterfall) | Kanban | XP (Extreme Programming) | Lean |
|----------|-------|---------------------|--------|---------------------------|------|
| **Tipo de abordagem** | Metodologia ágil baseada em ciclos iterativos. | Metodologia tradicional baseada em etapas sequenciais. | Método ágil focado em fluxo contínuo de trabalho. | Metodologia ágil voltada para práticas de desenvolvimento de software. | Filosofia de gestão voltada para eficiência e eliminação de desperdícios. |
| **Estrutura de trabalho** | Organização em Sprints com entregas incrementais. | Divisão do projeto em fases definidas e sequenciais. | Utiliza quadro visual para acompanhar o fluxo das tarefas. | Iterações curtas com forte integração entre desenvolvimento e testes. | Fluxo contínuo com foco na melhoria dos processos. |
| **Planejamento** | Planejamento realizado a cada Sprint com base no backlog do produto. | Planejamento detalhado realizado no início do projeto. | Planejamento contínuo conforme a demanda de trabalho. | Planejamento frequente com interação constante com o cliente. | Planejamento orientado à geração de valor para o cliente. |
| **Adaptação a mudanças** | Mudanças podem ser incorporadas entre as Sprints. | Mudanças são difíceis após o início do projeto. | Mudanças podem ocorrer a qualquer momento no fluxo. | Mudanças são esperadas e incorporadas rapidamente. | Mudanças são utilizadas para otimizar processos e eliminar desperdícios. |
| **Papéis da equipe** | Product Owner, Scrum Master e Time de Desenvolvimento. | Estrutura tradicional com gerente de projeto e equipe. | Não exige papéis formais definidos. | Desenvolvedores trabalham próximos ao cliente. | Equipes multidisciplinares e colaborativas. |
| **Foco principal** | Entrega contínua de valor ao cliente. | Cumprimento das fases planejadas do projeto. | Otimização do fluxo de trabalho. | Qualidade do código e boas práticas de programação. | Melhoria contínua e eficiência operacional. |



                                                                                                                             
                                                                                                                             
                                                                                                                             
                                                                                                                             
## Referências Bibliográficas

SCHWABER, Ken; SUTHERLAND, Jeff. O Guia do Scrum: O Guia Definitivo para o Scrum: As Regras do Jogo. [S.l.]: Scrum.org, 2020. Disponível em: https://scrumguides.org/docs/scrumguide/v2020/2020-Scrum-Guide-Portuguese-Brazilian.pdf. Acesso em: 12 mar. 2026.
SUTHERLAND, Jeff. Scrum: A arte de fazer o dobro do trabalho na metade do tempo. Rio de Janeiro: Leya, 2014.
SOMMERVILLE, Ian. Engenharia de Software. 10. ed. São Paulo: Pearson Education do Brasil, 2019.
RUBIN, Kenneth S. Essential Scrum: A Practical Guide to the Most Popular Agile Process. Upper Saddle River: Addison-Wesley, 2012.
https://www.totvs.com/blog/negocios/metodologia-agil/
•	SUTHERLAND, Jeff. Scrum: A arte de fazer o dobro do trabalho na metade do tempo. São Paulo: Leya, 2014. FIA
•	SCHWABER, Ken; SUTHERLAND, Jeff. O Guia do Scrum (The Scrum Guide). Disponível em: Scrum.org. (Documento oficial atualizado periodicamente). Wikipedia
•	SCHWABER, Ken. Agile Project Management with Scrum. Microsoft Press, 2004. ResearchGate
•	SCHWABER, Ken; BEEDLE, Mike. Agile Software Development with Scrum. Prentice Hall, 2001. UFRGS 
•	PRESSMAN, Roger S.; MAXIM, Bruce R. Engenharia de Software: Uma abordagem profissional. 9ª ed. Porto Alegre: AMGH, 2021. Atenas.edu
•	PROJECT MANAGEMENT INSTITUTE (PMI). Um Guia do Conhecimento em Gerenciamento de Projetos (Guia PMBOK). 7ª ed. Pennsylvania: PMI, 2021. (Inclui o Guia Prático Ágil). YouTube - Gestão de Projetos
•	SBROCCO, José Henrique T. C.; MACEDO, Paulo C. Metodologias Ágeis: Engenharia de Software Sob Medida. São Paulo: Érica, 2012. Livros1 
•	ANDERSON, David J. Kanban: Mudança Evolucionária de Sucesso para seu Negócio de Tecnologia. Blue Hole Press, 2011. Objective.com.br
•	BECK, Kent. Extreme Programming Explained: Embrace Change. 2ª ed. Addison-Wesley, 2004. UFRGS
•	KNIBERG, Henrik. Kanban e Scrum: obtendo o melhor de ambos. C4Media, 2010. Slideshare
