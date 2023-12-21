# Actio

## Create a solution and projects for microservices

```PowerShell
mkdir Actio
cd .\Actio\
dotnet new sln
mkdir src
mkdir scripts
mkdir tests
cd .\src\
dotnet new webapi -n Actio.Api
dotnet new webapi -n Actio.Services.Identity
dotnet new webapi -n Actio.Services.Activities
dotnet new classlib -n Actio.Common
dotnet new classlib -n Actio.Common
dotnet add .\Actio.Api\Actio.Api.csproj reference .\Actio.Common\Actio.Common.csproj
dotnet add .\Actio.Services.Identity\Actio.Services.Identity.csproj reference .\Actio.Common\Actio.Common.csproj
dotnet add .\Actio.Services.Activities\Actio.Services.Activities.csproj reference .\Actio.Common\Actio.Common.csproj
cd ..
cat .\Actio.sln
dotnet sln add .\src\Actio.Api\Actio.Api.csproj
dotnet sln add .\src\Actio.Common\Actio.Common.csproj
dotnet sln add .\src\Actio.Services.Activities\Actio.Services.Activities.csproj
dotnet sln add .\src\Actio.Services.Identity\Actio.Services.Identity.csproj
cat .\Actio.sln
dotnet restore
dotnet build
```