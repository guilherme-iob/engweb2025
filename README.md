# engweb2025

* https://visualstudio.microsoft.com/pt-br/vs/community
* https://github.com
* https://portal.azure.com ou https://azure.microsoft.com/pt-br/free    
* https://www.microsoft.com/pt-br/sql-server/sql-server-downloads 
* https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16 
* https://www.conventionalcommits.org/en/v1.0.0/
* https://dotnet.microsoft.com/pt-br/download/dotnet-framework [SDKs dos Frameworks Antigos]
* https://dotnet.microsoft.com/en-us/download [ SDKs do frameworks novo (dotnetcore)]

# Docs
* https://martinfowler.com/bliki/DesignStaminaHypothesis.html
* https://itnext.io/the-list-of-architectural-metapatterns-ed64d8ba125d
* https://itnext.io/deconstructing-patterns-a605967e2da6
* https://learn.microsoft.com/pt-br/dotnet/standard/linq

# Migração Framework
* https://learn.microsoft.com/en-us/dotnet/core/porting/upgrade-assistant-install
* https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.upgradeassistant
* dotnet tool install -g upgrade-assistant [Comando para instalar a ferramenta de migração]
* upgrade-assistant upgrade --targetFramework net8.0 [Comando para migrar os projetos em C#. Necessita instalar o upgrade-assistant pelo comando dotnet tool install]
* https://learn.microsoft.com/pt-br/azure/azure-sql/database/connect-query-dotnet-core?view=azuresql

# Pacotes utilizados
* Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation [web]
* Microsoft.Extensions.Configuration [web ]
* Microsoft.Extensions.Configuration.Json  [web ]
* Microsoft.EntityFrameworkCore.SqlServer [Etity Framework - Acesso aos dados]
  * Microsoft.EntityFrameworkCore
  * Microsoft.EntityFrameworkCore.Proxies
  * Microsoft.EntityFrameworkCore.Relational
* Microsoft.Extensions.DependencyInjection
* Microsoft.Data.SqlClient [ADO.NET]


# Migrações de Banco de Dados
* Conexão com o banco de dados: Arquivo ContextoBancoDados.cs
* Tabela de controle das migrações de banco de dados executadas: __EFMigrationsHistory

## Via dotnet CLI ou Terminal do VSCode
* **dotnet tool install --global dotnet-ef** [ Habilitar o cli via dotnet ef - Executar apenas uma vez ]
* **dotnet ef migrations add NomeDaMigracao** [ Criar uma migração. Sempre que quiser uma nova alteração no banco de dados ]
* **dotnet ef database update** [ Atualizar as migrações de banco de dados. Sempre que quiser efetivar no banco as mudanças ]
* Observar para estar no diretório do projeto que contém as migrações

## Via Visual Studio (Package Manager Console)
* Executar os comandos no Package Manager Console (View -> Other Windows -> Package Manager Console)
* **Add-Migration NomeDaMigraca**o [ Criar uma migração. Sempre que quiser uma nova alteração no banco de dados ]
* **Update-Database** [ Atualizar as migrações de banco de dados. Sempre que quiser efetivar no banco as mudanças ]
* Observar para marcar o projeto que contem as migrações de banco de dados
