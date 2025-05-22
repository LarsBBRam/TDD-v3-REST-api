# REST API

## COMMANDS

1. `dotnet new sln --name <namehere>`: Setup solution

2. `dotnet new web -n TaskManager`: Create Minimal API module

3. `dotnet new xunit -n TaskManager.Tests`: Setup test for module

Connect the dots:

1. `dotnet add TaskManager.Tests reference TaskManager`
2. `dotnet sln add TaskManager`
3. `dotnet sln add TaskManager.Tests`

Add additional dependencies (external)

1. `dotnet add TaskManager.Tests package Microsoft.AspNetCore.Mvc.Testing`:For testing Web APIs
