# RazorLab – ASP.NET Core Razor Pages Portfolio

A responsive educational website and portfolio starter project built with **ASP.NET Core Razor Pages (.NET 8)**.

## Features

- Responsive home page and navigation
- Razor Pages learning guide with code examples
- Project ideas rendered from C# model data
- Contact demonstration form with server-side model validation
- Shared layout, CSS styling and small JavaScript mobile navigation
- No database or external API required

## Requirements

- .NET 8 SDK
- Visual Studio 2022 (ASP.NET and web development workload) or Visual Studio Code with the C# Dev Kit

## Run with Visual Studio

1. Extract the ZIP file.
2. Open `RazorPagesPortfolio.csproj` in Visual Studio.
3. Allow NuGet restore to complete.
4. Press **F5** or click **https** run.

## Run with Visual Studio Code

1. Extract the ZIP file and open the `RazorPagesPortfolio` folder.
2. Open Terminal → New Terminal.
3. Run:

   ```bash
   dotnet restore
   dotnet build
   dotnet run
   ```

4. Open the localhost address printed in the terminal (normally `https://localhost:7043` or `http://localhost:5043`).

If the development HTTPS certificate is not trusted, run `dotnet dev-certs https --trust`, or use the HTTP address printed by the app.

## Pages

- `/` – Home
- `/Learn` – Razor Pages concepts and examples
- `/Projects` – Project ideas generated from C# data
- `/Contact` – Demonstration form with validation

## Contact form note

The form validates submitted data on the server and displays a confirmation. It does **not** send email or save messages to a database.

## Suggested next steps

- Add Entity Framework Core and SQL Server
- Add ASP.NET Core Identity for registration and login
- Add CRUD features to one of the project ideas
- Add automated tests
- Add screenshots and a project walkthrough to this README

## GitHub

Suggested repository name: `RazorPagesPortfolio`

Suggested description: `A responsive ASP.NET Core Razor Pages learning and portfolio website built with C# and .NET 8.`
