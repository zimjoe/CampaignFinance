# CampaignFinance

This is just a small project to load the Virginia Campaign Finance data to a CosmoDB on Azure.  I will then play with different structures to optimize search.


## Setup
// Create the solution file using your Namespace
dotnet new sln -n Aeveco.CampaignFinance
// lets create the projects
cd src
dotnet new classlib -n Aeveco.CampaignFinance.Application -o Application
dotnet new classlib -n Aeveco.CampaignFinance.Domain -o Domain
dotnet new classlib -n Aeveco.CampaignFinance.Infrastructure -o Infrastructure

dotnet new classlib -n Aeveco.CampaignFinance.WebApi -o WebApi
dotnet new classlib -n Aeveco.CampaignFinance.WebUI -o WebUI

dotnet new console -n Aeveco.CampaignFinance.Loader -o Loader

dotnet new azurefunction -n Aeveco.CampaignFinance.WebFunction -o WebFunction

cd ..\
dotnet sln add src\Application\Aeveco.CampaignFinance.Application.csproj
dotnet sln add src\Domain\Aeveco.CampaignFinance.Domain.csproj
dotnet sln add src\Infrastructure\Aeveco.CampaignFinance.Infrastructure.csproj

dotnet sln add src\WebApi\Aeveco.CampaignFinance.WebApi.csproj
dotnet sln add src\WebUI\Aeveco.CampaignFinance.WebUI.csproj

dotnet sln add src\Loader\Aeveco.CampaignFinance.Loader.csproj

// lets create the xunit tests for the various class layers.  
// This will start with very little coverage, but will grow with time
cd ..\tests
dotnet new xunit -n Aeveco.CampaignFinance.Application.Tests -o Application
dotnet new xunit -n Aeveco.CampaignFinance.Domain.Tests -o Domain
dotnet new xunit -n Aeveco.CampaignFinance.Infrastructure.Tests -o Infrastructure

dotnet sln add tests\Application\Aeveco.CampaignFinance.Application.Tests.csproj
dotnet sln add tests\Domain\Aeveco.CampaignFinance.Domain.Tests.csproj
dotnet sln add tests\Infrastructure\Aeveco.CampaignFinance.Infrastructure.Tests.csproj
