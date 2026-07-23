# JWT Authentication Hands-on Reference

This document summarizes the implementation of all four JWT Authentication hands-on exercises completed in this project.

---

# Question 1

## Objective

Implement JWT Authentication in ASP.NET Core Web API.

### Concepts Covered

- JWT Authentication
- Login API
- Token Generation
- Claims
- Authentication Middleware

### Important Configuration

Install Package

```bash
dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer
```

JWT Configuration

```csharp
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
.AddJwtBearer(...)
```

Generate Token

```csharp
JwtSecurityToken
```

Login Endpoint

```csharp
POST /api/Auth/login
```

---

# Question 2

## Objective

Secure API Endpoints using JWT Authentication.

### Controller

```csharp
[Authorize]
```

### Endpoint

```csharp
GET /api/Secure/data
```

### Result

Only authenticated users can access the endpoint.

---

# Question 3

## Objective

Implement Role-Based Authorization.

### JWT Claims

```csharp
new Claim(ClaimTypes.Role, "Admin")
```

### Controller

```csharp
[Authorize(Roles = "Admin")]
```

### Endpoint

```csharp
GET /api/Admin/dashboard
```

### Result

Only authenticated users with the Admin role can access the endpoint.

---

# Question 4

## Objective

Handle Expired or Invalid JWT Tokens Gracefully.

### JWT Events

```csharp
options.Events = new JwtBearerEvents()
```

### Authentication Failed

```csharp
OnAuthenticationFailed
```

### Unauthorized Response

```csharp
OnChallenge
```

### Custom Response

```json
{
    "message":"Unauthorized. Invalid or expired token."
}
```

---

# Security Features Implemented

- JWT Authentication
- JWT Validation
- Token Expiration Validation
- Issuer Validation
- Audience Validation
- Signing Key Validation
- Role-Based Authorization
- Swagger Authentication Support

---

# Project Outcome

The project demonstrates:

- Authentication
- Authorization
- JWT Token Generation
- JWT Token Validation
- Claims-Based Identity
- Role-Based Authorization
- Secure REST APIs
- Swagger JWT Integration

All four JWT Authentication hands-ons have been successfully integrated into a single ASP.NET Core Web API project.