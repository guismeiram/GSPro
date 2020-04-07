# GSPro
GSPro(Gestor de Siatis)

O projeto foi criado, a partir da necessidade de gerar soluções para Área de Produção.

O projeto foi feito, utilizando métodos e ferramentas da seguinte maneira.

-Camada de DevIO.Bussines é constituída , por Interfaces(Nesta pasta foi criada assinatura de métodos, 
cujo a responsabilidade para implementação ficou para camada DevIO.Data) e Models(fica responsável pelas classes de persistência no banco)

-Geração de tabelas, configuração DbContext e mapeamento, ficou sobre a responsabilidade DevIO.Data, nesta camada foi implementada
as Intercaces(pasta Repository).

-Já na camada DevIO.App( Foi utilizado Framework Indentity, onde facilitou a criação de tabelas com entity e geração de telas), 
foi preciso utilizar o recurso de AutoMapper, para mapeamento das Classes Models e ViewModels. 
Nesse contexto, foi gerado as View a partir da estrutura do banco. Foi editado a classe Controller e ajustado o layout das páginas.

