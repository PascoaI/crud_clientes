# CRUD Clientes

Este projeto é uma aplicação CRUD (Create, Read, Update, Delete) desenvolvida com **ASP.NET MVC** e **Entity Framework**, conectada a uma base de dados SQL. Ele permite a manipulação de registros de clientes, utilizando as funcionalidades de criação, leitura, atualização e exclusão.

## Tecnologias Utilizadas

- **ASP.NET MVC**: Framework para desenvolvimento web usando o padrão Model-View-Controller.
- **Entity Framework Core**: ORM utilizado para gerenciar o acesso ao banco de dados SQL.
- **Bootstrap**: Utilizado para estilização da interface.
- **SQL Server**: Banco de dados utilizado para armazenar as informações dos clientes.

## Funcionalidades

- **Adicionar Cliente**: Permite adicionar um novo cliente com nome, data de nascimento e status de atividade.
- **Editar Cliente**: Edita as informações de um cliente existente.
- **Detalhes do Cliente**: Visualiza os detalhes de um cliente.
- **Excluir Cliente**: Exclui um cliente da base de dados.

## Pré-requisitos

- **.NET SDK**: Versão 6.0 ou superior.
- **SQL Server**: Para hospedar o banco de dados.
- **Visual Studio**: Recomenda-se o Visual Studio 2022 ou superior com suporte para ASP.NET.

## Configurando o Projeto no Localhost

Siga as etapas abaixo para configurar e rodar o projeto no seu ambiente local.

### 1. Clone o Repositório

No terminal, execute:

git clone https://github.com/PascoaI/crud_clientes.git

### 2. Abra o Projeto no Visual Studio
Navegue até a pasta do projeto clonado e abra o arquivo .sln no Visual Studio.

### 3. Configurar a Conexão com o Banco de Dados
No arquivo appsettings.json, você deve configurar a string de conexão do banco de dados para utilizar o SQL Server local. Certifique-se de que o SQL Server está instalado e rodando em sua máquina.

Aqui está um exemplo de configuração para um ambiente localhost:

 *"ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=CrudClientesDB;Trusted_Connection=True;MultipleActiveResultSets=true"
}*

### 4. Migrar o Banco de Dados
Execute o comando abaixo no Package Manager Console ou no terminal do VS/VSCode para aplicar as migrações e criar o banco de dados:

*Update-Database*

Isso criará a estrutura do banco de dados necessária para a aplicação.

### 5. Rodar a Aplicação
Na IDE, vá até o terminal e digite *dotnet run* para executar a aplicação, e acesse o localhost no seu navegador.

## Estrutura do Projeto
- **Models**: Contém as classes que representam o modelo de dados, como Cliente.
- **Controllers**: Contém os controladores que lidam com as requisições HTTP e manipulam os dados.
- **Views**: Contém as páginas da interface que renderizam o HTML para o navegador.
- **Migrations**: Diretório que contém as migrações do banco de dados geradas pelo Entity Framework.
