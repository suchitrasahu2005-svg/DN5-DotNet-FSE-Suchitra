# API Testing Guide

The project has been tested using Swagger UI.

---

## Base URL

```
http://localhost:5012
```

---

# 1. Get All Employees

### Endpoint

```
GET /api/Employee
```

### Expected Response

```json
[
    {
        "id":1,
        "name":"Rahul",
        "department":"IT"
    },
    {
        "id":2,
        "name":"Priya",
        "department":"HR"
    }
]
```

---

# 2. Get Employee By Id

### Endpoint

```
GET /api/Employee/1
```

Requires Header

```
AuthKey : 12345
```

---

# 3. Add Employee

### Endpoint

```
POST /api/Employee
```

Sample Body

```json
{
    "id":3,
    "name":"John",
    "department":"Finance",
    "salary":65000
}
```

---

# 4. Update Employee

### Endpoint

```
PUT /api/Employee/1
```

Sample Body

```json
{
    "id":1,
    "name":"Rahul Sharma",
    "department":"IT",
    "salary":70000
}
```

---

# 5. Delete Employee

### Endpoint

```
DELETE /api/Employee/1
```

---

# 6. Exception Filter

When an unhandled exception occurs, the API returns

```json
{
    "message":"An unexpected error occurred.",
    "error":"Exception Message"
}
```

---

# 7. Authorization Filter

Without AuthKey

```
401 Unauthorized
```

With Header

```
AuthKey : 12345
```

Returns Employee Details Successfully.

---

## Swagger

Swagger is available at

```
http://localhost:5012/swagger
```

All endpoints were successfully tested through Swagger.