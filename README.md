# Blog Sample Application

This is a small **Blazor Server** demo project built to showcase clean architecture, adherence to **SOLID principles**, and modern **.NET 6** development practices.  
It demonstrates a minimal **Blog Post Management** module where users can create and view posts using **Entity Framework Core (Code First)**, **Dependency Injection**, and **Test-Driven Development (TDD)** techniques.

---

## Overview

The project is structured to emphasize **separation of concerns** and **testability**:

Blog/

├── Data/ → EF Core DbContext

├── Models/ → Domain entities

├── Services/ → Business logic (interfaces + implementations)

├── Pages/ → Blazor UI components

└── Tests/ → xUnit unit tests


### Design Choices
- **SOLID principles** enforced:
  - **S**ingle Responsibility: Each class has one clear purpose.
  - **O**pen/Closed: Business logic is extendable without modification.
  - **L**iskov Substitution: Interfaces ensure interchangeability.
  - **I**nterface Segregation: Services expose only needed members.
  - **D**ependency Inversion: High-level modules depend on abstractions.
- **Entity Framework Core (In-Memory)** for persistence.
- **Dependency Injection** via `Program.cs`.
- **Async/Await** patterns throughout for responsiveness.
- **Clean UI** built with **Blazor** and Razor components.

---

## Technologies

| Layer | Technology |
|-------|-------------|
| Front-End | Blazor Server (.NET 6) |
| Backend | ASP.NET Core, C# |
| Data | Entity Framework Core (In-Memory DB) |
| Testing | xUnit, Moq |
| IDE | Visual Studio / VS Code |

---

## Steps to use

1. **Clone Repository**
   ```
   bash
   git clone https://github.com/dantejlarocco/Blog.git 
   cd Blog
   ```
2. **Run Application**
  ```
  dotnet run
  ```

Then navigate to http://localhost:5000/blog

3. **Run Tests**
  ```
  dotnet test
  ```
