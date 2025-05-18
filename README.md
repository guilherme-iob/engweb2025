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
