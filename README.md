# Online Accounting Server · Architecture Scaffold

**An ASP.NET Core solution scaffold for exploring layered application structure.**

C# · .NET 8 · Swagger

This repository establishes Application, Domain, Infrastructure, Persistence, Presentation and WebAPI projects. It currently exposes a test controller; accounting features are not implemented yet.

## Explore

- [Application and Domain projects](src/Core)
- [Presentation layer](src/External/OnlineAccountingServer.Presentation)
- [API startup](src/OnlineAccountingServer.WebApi/Program.cs)

## Run locally

```bash
git clone https://github.com/bora399/OnlineAccountingServer.git
cd OnlineAccountingServer
dotnet restore OnlineAccountingServer.sln
dotnet run --project src/OnlineAccountingServer.WebApi/OnlineAccountingServer.WebApi.csproj --launch-profile http
```

Use .NET 8 SDK and open `http://localhost:5024/swagger`.

JWT middleware is registered, but a complete identity/token configuration and accounting domain are outside the current scope. Treat this as an architecture exercise rather than a deployed accounting product.
