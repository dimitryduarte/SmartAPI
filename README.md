# SmartAPI
Um Web Service RESTful para gerenciamento de funcionários
## Introdução
Este projeto se trata de um Web Service RESTful (formato JSON) que disponibiliza os seguintes serviços:

* Serviço que localiza/retorna funcionários por Nome;
* Serviço que localiza/retorna funcionários por CPF;
* Serviço que localiza/retorna funcionários por Cargo;
* Serviço que localiza/retorna funcionários por Data de Cadastros;
* Serviço que retorna funcionários agrupados por UF de Nascimento, de forma quantitativa;
* Serviço que localiza/retorna funcionários por status;
* Serviço que localiza/retorna funcionários por faixa salarial;
* Serviço para excluir um funcionário pelo número do CPF;
* Serviço para incluir um novo funcionário (caso o funcionário já exista, apenas atualizar);
* **(Extra) Serviço de localização dinâmico de funcionários com multiplos filtros.**

### Pré-Requisitos

Ferramentas utilizadas no desenvolvimento deste projeto:
Back-End:
* Visual Studio 2019 - Community
* SQL Server Developer

Ambos são gratuitos e podem ser baixados em:
* [Visual Studio 2019 - Community](https://visualstudio.microsoft.com/pt-br/) - IDE do Visual Studio
* [SQL Server Developer](https://go.microsoft.com/fwlink/?linkid=853016) - SQL Server na infraestrutura local

### Instalação

Passo a passo para executar o projeto.

No SQL Server:

1 - Realize a importação do arquivo CSV com os dados de funcionários renomeado para TB_FUNCIONARIOS para o banco criado com o nome desafio.
```
CREATE DATABASE desafio;
```

Referência de como realizar a importação:
* [Import CSV - SQL Server](https://support.discountasp.net/kb/a1179/how-to-import-a-csv-file-into-a-database-using-sql-server-management-studio.aspx)

2 - Execute os scripts no banco para ajustar a tabela importada e criar as views utilizadas no projeto:
```
Alter table TB_FUNCIONARIOS alter column DataCad date;
go
Alter table TB_FUNCIONARIOS alter column Salario money;
go
create view TB_FUNCIONARIOSAGRUP
as
select UFNasc, count(1) as Quant
  from TB_FUNCIONARIOS
 group by UFNasc;
```

3 - Após abrir o projeto modifique a string de conexão do contexto em:
-> SmartAPI.Dados\Contexto\Context.cs

4 - Caso for necessário, pelo gerenciador de pacotes do NuGet, instale as dependências do projeto (Swagger, etc).

5 - Clique com o botão direito em SmartAPI.Api, selecione Propriedades -> Web.
 A API está configurada para enviar as requisições para a porta ```localhost:44365``` então confirme se a URL projeto está apontando para essa porta.
 Após isso, clique em "Criar Diretório Virtual".

6 - Após instalação das dependências, configuração da conexão, e criação dos dados, basta executar o projeto (Executar - F5);

Ps.: Caso o visual studio apresente algum lixo/erro, basta clicar na solution e selecionar a opção "clean", após isso, clique em cada projeto e selecione a opção "rebuild". Após isso basta executar novamente (Executar - F5);

## Executando os testes

Para executar os testes unitários:
1 - Acesse: Teste -> Gerenciador de Teste
2 - No suite de teste SmartAPI.Tests, Selecione a opção: Executar

## Executando o projeto
Para realizar os testes da API basta compilar o projeto e será aberta uma pagina inicial do swagger com as requisições.
Obs.: Não é necessário realizar autenticação para dar inicio às requisições.

## Autor

* **Dimitry Duarte** - [CV](https://dimitryduarte.000webhostapp.com/)

Repositórios em: [Repositórios](https://github.com/dimitryduarte?tab=repositories).
