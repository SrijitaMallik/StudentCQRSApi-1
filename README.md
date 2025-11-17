# 🎓 StudentCQRSApi

A clean and simple **ASP.NET Core Web API** implementing **CQRS (Command Query Responsibility Segregation)** and **Mediator Pattern (MediatR)**.  
Data is stored **in-memory**, and the API supports full CRUD operations for managing students.

---

## 🚀 Features

- CQRS Architecture (Commands + Queries)
- Mediator Pattern using **MediatR**
- In-Memory Repository (No database needed)
- CRUD Operations for Students
- Clean folder-based architecture
- Swagger API Docs auto-enabled
- Easily extendable to EF Core / SQL

---
## 🏗️ Architecture Diagram
Controller → Mediator → Handler → Repository → In-Memory Data

##🛠️ Tech Stack

ASP.NET Core Web API
MediatR
CQRS
Dependency Injection
In-memory Data Store
Swagger / Swashbuckle

##📝 Future Enhancements

Add Database (EF Core + SQL Server)
Add AutoMapper + DTO Validation
Add Unit Tests
Logging / Pipeline Behaviors
Authentication & Authorization
