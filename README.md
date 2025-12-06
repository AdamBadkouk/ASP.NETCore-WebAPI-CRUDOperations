# ASP.NET Core WebAPI CRUD Operations

A modern RESTful Web API built with **ASP.NET Core (.NET 10)** and **Entity Framework Core** that demonstrates complete CRUD operations for managing products.

## Key Features

- **Full CRUD Operations** - Create, Read, Update, and Delete 
- **RESTful API Design** - Follows REST architectural principles
- **Entity Framework Core** - Code-first database approach with migrations
- **SQL Server Integration** - Robust database connectivity
- **Swagger/OpenAPI** - Interactive API documentation and testing
- **Async/Await Pattern** - Asynchronous operations for better performance
- **Clean Architecture** - Organized project structure with separation of concerns

## Technologies Used

- **Framework**: ASP.NET Core (.NET 10)
- **ORM**: Entity Framework Core
- **Database**: SQL Server (LocalDB/SQL Server Express 2025)
- **API Documentation**: Swagger/Swashbuckle
- **Language**: C# 14

## Package References

The project uses the following NuGet packages:

- `Microsoft.EntityFrameworkCore` (10.0.0)
- `Microsoft.EntityFrameworkCore.SqlServer` (10.0.0)
- `Microsoft.EntityFrameworkCore.Tools` (10.0.0)
- `Microsoft.AspNetCore.OpenApi` (10.0.0)
- `Swashbuckle.AspNetCore.Swagger` (10.0.1)
- `Swashbuckle.AspNetCore.SwaggerGen` (10.0.1)

## Prerequisites

Before running this project, ensure you have the following installed:

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0) 
- [SQL Server](https://www.microsoft.com/sql-server/sql-server-downloads) (SQL Server 2025 Express)
- [Visual Studio 2026](https://visualstudio.microsoft.com/) (recommended) or [Visual Studio Code](https://code.visualstudio.com/)

## Getting Started

### 1. Clone the Repository

```bash
git clone https://github.com/AdamBadkouk/ASP.NETCore-WebAPI-CRUDOperations.git
cd WebApi
```

### 2. Configure Database Connection

Update the connection string in `appsettings.json` to match your SQL Server instance:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=YOUR_DB_NAME;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=True"
  }
}
```

> **Note**:
> - Replace `YOUR_SERVER_NAME` with your actual SQL Server instance name.
> - Replace `YOUR_DB_NAME` with your actual Database name

### 3. Apply Database Migrations

The database migrations are already created. Apply them using:

```bash
cd WebApi
dotnet ef database update
```

If you need to create new migrations in the future:

```bash
dotnet ef migrations add MigrationName
dotnet ef database update
```

### 4. Run the Application

#### Using Visual Studio:
1. Open `WebApi.slnx` 
2. Press `F5` or click the **Run** button

#### Using .NET CLI:
```bash
cd WebApi
dotnet run
```

The API will start and be available at:
- **HTTPS**: `https://localhost:7286`
- **HTTP**: `http://localhost:5212`

### 5. Access Swagger UI

Once the application is running, navigate to:
```
https://localhost:7286/swagger/index.html
```

This will open the interactive Swagger UI where you can test all API endpoints.
