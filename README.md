# Filters

A collection of small sample projects demonstrating the different types of **Filters** in **ASP.NET Core**. Each project focuses on one filter type, with explanations and working code examples.

## Filter Types in This Repo

| # | Filter | Short Description |
|---|--------|--------------------|
| 1 | [Action Filters](/ActionFilters/README.md) | Run before and after the execution of the Action Method itself |
| 2 | [Resource Filters](./ResourceFilters/README.md) | Run right after Authorization, used to verify the resource rather than the user's identity |
| 3 | [Result Filters](./ResultFilters/README.md) | Control the shape of the Response returned from an Action |
| 4 | [Exception Filters](./ExceptionFilters/README.md) | Catch unexpected exceptions and prevent leaking sensitive details |
| 5 | [Endpoint Filters](./EndPointsFilters/README.md) | Applied to Minimal APIs |

## Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (version used across the projects)
- An IDE such as Visual Studio, JetBrains Rider, or VS Code

## Cloning the Repo

```bash
git clone https://github.com/AbdAlAleem-Hassan/Filters.git
cd Filters
```

Alternatively, you can download a ZIP directly from the **Code > Download ZIP** button on the repo's GitHub page.

## Running a Project

1. Open the `Filters.slnx` file in your IDE, or go directly into the folder of the project you want to try.
2. Run the following command inside the project folder:

```bash
dotnet run
```

## Exploring the Projects

Each folder listed above is a standalone project, and inside each one you'll find its own `README.md` explaining:

- What that filter is and when it runs in the pipeline.
- The different ways to register it.
- Code examples taken from the project itself.

Use the table above and click on the filter you want to read about.
