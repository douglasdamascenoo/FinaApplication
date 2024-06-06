## Criação do Projeto Fina App
No terminal execute os comandos abaixo
- mkdir Fina
- cd Fina
- dotnet new sln
- dotnet new web -o Fina.Api
- dotnet new blazorwasm -o Fina.App --pwa
- dotnet new classlib -o Fina.Core
- dotnet sln add .\Fina.Core\
- dotnet sln add .\Fina.Api\
- dotnet sln add .\Fina.App\
- dotnet add reference ..\Fina.Core\ (na pasta dos dois projetos App e Api)

Api
- SqlServer
> dotnet add package Microsoft.EntityFrameworkCore.SqlServer
> dotnet add package Microsoft.EntityFrameworkCore.Design

- Migrations
-- Instalar ferramentas do ef
> dotnet tool install --global dotnet-ef
-- Cria uma migrations
> dotnet ef migrations add v1
-- Aplicar mudanças no banco
> dotnet ef database update
