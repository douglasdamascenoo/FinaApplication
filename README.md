## Criação do Projeto Fina App
No terminal execute os comandos abaixo

1. Criando o diretório do projeto `Fina`.
```
mkdir Fina
```
2. Navegando para o diretório criado.
```
cd Fina
```
3. Criando o arquivo de solução.
```
dotnet new sln
```
4. Criando o projeto de API.
```
dotnet new web -o Fina.Api
```
5. Criando o projeto de aplicação PWA.
```
dotnet new blazorwasm -o Fina.App --pwa
```
6. Criando o projeto de domínio de negócio e recursos compartilhados.
```
dotnet new classlib -o Fina.Core
```
7. Adicionando os projeto à solução.
```
dotnet sln add .\Fina.Core\
dotnet sln add .\Fina.Api\
dotnet sln add .\Fina.App\
```
8. Adicionando referência do projeto ``Fina.Core`` à API ``Fina.Api``.
```
cd .\Fina.App\
dotnet add reference ..\Fina.Core\
```
9. Adicionando referência do projeto ``Fina.Core`` à aplicação PWA ``Fina.App``.
```
cd .\Fina.App\
dotnet add reference ..\Fina.Core\
```
10. Banco de Dados e Migrations.
> Adicionando o pacote do Entity Framework (SqlServer) à API.
```
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
```
> Adicionando o recurso de Design para utilização no Migrations
```
dotnet add package Microsoft.EntityFrameworkCore.Design
```

> Instalando ferramentas do EF Core.
```
dotnet tool install --global dotnet-ef
```
> Criando uma migração.
```
dotnet ef migrations add v1
```
> Aplicar mudanças do migrations no banco de dados.
```
dotnet ef database update
```
