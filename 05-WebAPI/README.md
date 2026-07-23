# Employee Web API - Cognizant Digital Nurture 5.0

## Overview

This project is developed as part of the Cognizant Digital Nurture 5.0 DotNet Full Stack Engineer Program.

The application demonstrates the implementation of ASP.NET Core 8 Web API concepts through six hands-on exercises. All the hands-ons have been integrated into a single project while preserving the functionality of each exercise.

---

## Technologies Used

- ASP.NET Core 8 Web API
- C#
- Swagger / OpenAPI
- Dependency Injection
- REST API
- DTO (Data Transfer Object)
- Custom Filters
- Visual Studio Code

---

## Project Structure

```
EmployeeWebAPI
│
├── Controllers
│   └── EmployeeController.cs
│
├── DTOs
│   └── EmployeeDTO.cs
│
├── Filters
│   ├── CustomExceptionFilter.cs
│   └── CustomAuthFilter.cs
│
├── Models
│   └── Employee.cs
│
├── Services
│   ├── IEmployeeService.cs
│   └── EmployeeService.cs
│
├── Program.cs
│
└── appsettings.json
```

---

## Features Implemented

- RESTful CRUD Operations
- Dependency Injection
- DTO Implementation
- Global Exception Handling
- Custom Authorization Filter
- Swagger API Documentation

---

## Hands-ons Covered

- Handson 1 – Create ASP.NET Core Web API
- Handson 2 – CRUD Operations
- Handson 3 – Dependency Injection
- Handson 4 – DTO Implementation
- Handson 5 – Custom Exception Filter
- Handson 6 – Custom Authorization Filter

Detailed implementation is available in **WebAPI_Handson_Reference.md**

---

## Running the Project

Clone the repository

```
git clone <repository-url>
```

Navigate to the project

```
cd EmployeeWebAPI
```

Run

```
dotnet restore
dotnet build
dotnet run
```

Open Swagger

```
http://localhost:5012/swagger
```

---

## API Documentation

Swagger UI is enabled.

All endpoints can be tested directly using Swagger.

---

## Author

**Deepsikha Patra**

Cognizant Digital Nurture 5.0

DotNet Full Stack Engineer

## Notes

This project combines all six Web API hands-on exercises into a single ASP.NET Core Web API application. Each hands-on has been successfully implemented, tested, and documented in the accompanying reference files.