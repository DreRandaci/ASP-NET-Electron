# Number Cruncher
This project is an [Electron.NET Core](https://github.com/ElectronNET/Electron.NET) expense tracker built mainly for personal use, but feel free to pull the project down and run it locally on your machine. The aim of the project is to better understand Electron's build process and make a native desktop MVC application that can be used on Linux and Windows. A potential v2 may include an Electron mobile application and deployment of the .NET Core Web API.

> This project was built using Visual Studio Code. It is not currently at MVP for v1 but feel free to poke around the repo

**Prerequisites for installation**:

- [.NET Core 2.0](https://www.microsoft.com/net/learn/get-started/macos) is installed
- Entity Framework and Entity Framework Tools are installed:
```sh
# NuGet
PM> Install-Package Microsoft.EntityFrameworkCore.Tools

# .NET CLI
$ dotnet add package Microsoft.EntityFrameworkCore.Design
$ dotnet restore
```
- SQLite package installed:
```sh
# NuGet
PM> Install-Package System.Data.SQLite

# .NET CLI
$ dotnet add package System.Data.SQLite
$ dotnet restore
```

## Installation

- Clone the repo:
```sh
# SSH
$ git clone git@github.com:DreRandaci/Number-Cruncher.git

# HTTPS
$ git clone https://github.com/DreRandaci/Number-Cruncher.git
```
- Install `Electron.NET` through `NuGet` or `.NET CLI`:
```sh
# NuGet
PM> Install-Package ElectronNET.API

# .NET CLI
$ dotnet add package ElectronNET.API --version 0.0.9
```
- Add the proper `environment` variable to your system for the path to the database in your `shell` command file. This is the code that requires the path in `Startup.cs`:
```csharp
string path = System.Environment.GetEnvironmentVariable("NUMBER_CRUNCHER");
            var connection = $"Filename={path}";
            Console.WriteLine($"connection = {connection}");
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlite(connection));

```
- Build the database:
```sh
# NuGet
PM> Update-Database

# .NET CLI
$ dotnet ef database update
```
- **Restore** the project:
```sh
# .NET CLI
$ dotnet restore
```