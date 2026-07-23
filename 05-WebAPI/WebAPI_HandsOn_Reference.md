# ASP.NET Core Web API Hands-on Reference

This document summarizes the implementation of all six Web API hands-ons completed in this project.

---

# Handson 1

## Objective

Create a basic ASP.NET Core Web API application.

### Concepts Covered

- ASP.NET Core Web API
- Controllers
- Routing
- Swagger

### Important Code

Register Controllers

```csharp
builder.Services.AddControllers();
```

Map Controllers

```csharp
app.MapControllers();
```

Controller Routing

```csharp
[ApiController]
[Route("api/[controller]")]
```

---

# Handson 2

## Objective

Implement CRUD operations for Employee.

### Endpoints

GET

```csharp
[HttpGet]
```

GET By Id

```csharp
[HttpGet("{id}")]
```

POST

```csharp
[HttpPost]
```

PUT

```csharp
[HttpPut("{id}")]
```

DELETE

```csharp
[HttpDelete("{id}")]
```

### Model Used

Employee.cs

```csharp
public class Employee
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Department { get; set; }

    public decimal Salary { get; set; }
}
```

---

# Handson 3

## Objective

Implement Dependency Injection using Service Layer.

### Interface

```csharp
IEmployeeService
```

### Service

```csharp
EmployeeService
```

### Registration

```csharp
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
```

### Constructor Injection

```csharp
private readonly IEmployeeService _employeeService;

public EmployeeController(IEmployeeService employeeService)
{
    _employeeService = employeeService;
}
```

---

# Handson 4

## Objective

Implement DTO (Data Transfer Object).

### DTO Class

```csharp
public class EmployeeDTO
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Department { get; set; }
}
```

### Mapping

```csharp
.Select(e => new EmployeeDTO
{
    Id = e.Id,
    Name = e.Name,
    Department = e.Department
})
```

### Benefit

- Hides Salary field
- Prevents exposing unnecessary data
- Better API design

---

# Handson 5

## Objective

Implement Global Exception Handling.

### Filter

```csharp
CustomExceptionFilter
```

### Registration

```csharp
builder.Services.AddControllers(options =>
{
    options.Filters.Add<CustomExceptionFilter>();
});
```

### Response

```json
{
  "message": "An unexpected error occurred.",
  "error": "Exception Message"
}
```

---

# Handson 6

## Objective

Implement Custom Authorization Filter.

### Filter

```csharp
CustomAuthFilter
```

### Authorization Logic

Checks

```
AuthKey
```

Expected Value

```
12345
```

Usage

```csharp
[CustomAuthFilter]
```

### Unauthorized Response

```json
{
    "message":"Authorization Failed."
}
```

---

# Project Outcome

The project demonstrates:

- ASP.NET Core Web API
- REST API Design
- CRUD Operations
- Dependency Injection
- DTO Pattern
- Global Exception Handling
- Authorization Filters
- Swagger Integration

All six hands-ons have been successfully integrated into a single ASP.NET Core Web API project.