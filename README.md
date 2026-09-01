# ZAnime

An ASP.NET Core MVC web application for managing an anime library, built with the Repository Pattern and Entity Framework Core over SQL Server.

The project was built to practice the MVC architectural pattern, separating business logic from data access, and building a responsive, server-rendered web application from scratch.

---

## Tech Stack

- **Language:** C#
- **Framework:** ASP.NET Core MVC
- **Database:** SQL Server with Entity Framework Core
- **Views:** Razor Views, Bootstrap

---

## Architecture

The application follows the MVC pattern, with the Repository Pattern separating business logic from data access:

```
Controllers/
Models/
Repositories/
Views/
```

---

## Features

- Browse all anime entries
- Search anime by title
- Add, edit, and delete anime
- View anime details
- Server-side validation
- Asynchronous database operations

> **Note:** Genre management is partially implemented and planned for future completion — see Future Work below.

---

## Pages & Routes

This is a server-rendered MVC app, so these return HTML views, not JSON — routes follow ASP.NET Core's default `{controller}/{action}/{id?}` convention routing.

### Anime

| Method | Route                   | Description                                    |
| ------ | ------------------------ | ------------------------------------------------ |
| GET    | `/Anime`                | List all anime, or search via `?searchString=`  |
| GET    | `/Anime/Create`         | Show the create form                            |
| POST   | `/Anime/Create`         | Submit a new anime (rejects duplicate titles)   |
| GET    | `/Anime/Edit/{id}`      | Show the edit form for an anime                 |
| POST   | `/Anime/Edit`           | Submit edits to an anime                        |
| GET    | `/Anime/Details/{id}`   | View an anime's details                         |
| GET    | `/Anime/Delete/{id}`    | Show the delete confirmation page               |
| POST   | `/Anime/Delete`         | Confirm and delete an anime                     |

### Home

| Method | Route          | Description       |
| ------ | --------------- | ------------------ |
| GET    | `/` or `/Home`  | Home page          |
| GET    | `/Home/Privacy` | Privacy page       |
| GET    | `/Home/Error`   | Error page         |

---

## Getting Started

### Prerequisites

- .NET SDK
- SQL Server
- Visual Studio 2022 (recommended)

### Setup

1. **Clone the repository**

```bash
git clone https://github.com/zezoz5/ZAnime.git
```

2. **Update the connection string** inside `appsettings.json`.

3. **Apply migrations**

```bash
dotnet ef database update
```

4. **Run the application**

```bash
dotnet run
```

---

## What I Learned

- Structuring an ASP.NET Core MVC application with the Repository Pattern, keeping controllers thin and data access isolated
- Server-side model validation and asynchronous CRUD operations with Entity Framework Core
- Building and wiring up Razor Views against a real SQL Server-backed data model

---

## Future Work

- Complete genre management
- Add pagination
- Add authentication and authorization
- Improve responsive design and overall UI

---

## A Note from the Developer

ZAnime was built to get comfortable with the MVC pattern and the Repository Pattern in a real, if smaller, application — a step before the more architecturally deliberate work in TaskFlow.

---

## License

This project is licensed under the MIT License.
