# ZAnime

ZAnime is an ASP.NET Core MVC web application for managing an anime library. The project was built to practice the MVC architectural pattern, the Repository Pattern, and Entity Framework Core while creating a responsive web application backed by SQL Server.

## Features

- 📋 Browse all anime entries
- 🔍 Search anime by title
- ➕ Add new anime
- ✏️ Edit existing anime
- 🗑️ Delete anime
- 📄 View anime details
- ✅ Server-side validation
- ⚡ Asynchronous database operations

> **Note**
> The genre feature is partially implemented and planned for future completion.

## Tech Stack

- C#
- ASP.NET Core MVC
- Entity Framework Core
- SQL Server
- Razor Views
- Bootstrap

## Architecture

The application follows the ASP.NET Core MVC pattern and uses the Repository Pattern to separate business logic from data access.

```
Controllers/
Models/
Repositories/
Views/
```

## Getting Started

### Prerequisites

- .NET SDK
- SQL Server
- Visual Studio 2022 (recommended)

### Installation

1. Clone the repository

```bash
git clone https://github.com/zezoz5/ZAnime.git
```

2. Update the connection string inside `appsettings.json`.

3. Apply the Entity Framework Core migrations.

```bash
dotnet ef database update
```

4. Run the application.

```bash
dotnet run
```

## Learning Outcomes

This project helped me gain hands-on experience with:

- ASP.NET Core MVC
- Repository Pattern
- Entity Framework Core
- Razor Views
- SQL Server integration
- CRUD application development
- Model validation
- Asynchronous programming with C#

## Future Improvements

- Complete the genre management feature
- Improve the user interface
- Add pagination
- Add authentication and authorization
- Improve responsive design

## License

This project is licensed under the MIT License.
