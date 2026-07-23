# JWT Authentication API - Cognizant Digital Nurture 5.0

## Overview

This project is developed as part of the Cognizant Digital Nurture 5.0 DotNet Full Stack Engineer Program.

The application demonstrates the implementation of Authentication and Authorization in ASP.NET Core Web API using JWT (JSON Web Token).

All four hands-on exercises have been integrated into a single project while preserving the functionality of each exercise.

---

## Technologies Used

- ASP.NET Core 8 Web API
- C#
- JWT Authentication
- JWT Authorization
- Swagger / OpenAPI
- Role-Based Authorization
- REST API
- Visual Studio Code

---

## Project Structure

```
JWTAuthenticationAPI
│
├── Controllers
│   ├── AuthController.cs
│   ├── SecureController.cs
│   └── AdminController.cs
│
├── Models
│   ├── LoginModel.cs
│   └── UserModel.cs
│
├── Program.cs
├── appsettings.json
└── JWTAuthenticationAPI.csproj
```

---

## Features Implemented

- JWT Authentication
- Login API
- JWT Token Generation
- Secure API Endpoints
- Role-Based Authorization
- Custom JWT Validation
- Custom Unauthorized Response
- Swagger JWT Authentication Support

---

## Hands-ons Covered

- Question 1 – Implement JWT Authentication
- Question 2 – Secure API Endpoint Using JWT
- Question 3 – Role-Based Authorization
- Question 4 – Handle Unauthorized / Expired JWT Tokens

Detailed implementation is available in **JWT_Handson_Reference.md**

---

## Running the Project

Clone the repository

```
git clone <repository-url>
```

Navigate to the project

```
cd JWTAuthenticationAPI
```

Run

```
dotnet restore
dotnet build
dotnet run
```

Open Swagger

```
http://localhost:5295/swagger
```

*(Use the port displayed in your terminal if it is different.)*

---

## Notes

This project combines all four JWT Authentication hands-on exercises into a single ASP.NET Core Web API application. Each hands-on has been successfully implemented, tested, and documented in the accompanying reference files.

---

## Author

**Deepsikha Patra**

Cognizant Digital Nurture 5.0

DotNet Full Stack Engineer