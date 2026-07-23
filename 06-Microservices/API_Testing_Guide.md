# JWT Authentication API Testing Guide

The project has been tested using Swagger UI.

---

## Base URL

```
http://localhost:5295
```

*(Use the port shown by your application if different.)*

---

# 1. Login

### Endpoint

```
POST /api/Auth/login
```

### Request Body

```json
{
    "username":"admin",
    "password":"admin123"
}
```

### Expected Response

```json
{
    "message":"Login Successful",
    "token":"<JWT Token>"
}
```

---

# 2. Secure Endpoint

### Endpoint

```
GET /api/Secure/data
```

### Authorization

Requires JWT Token.

Use Swagger **Authorize** button and enter

```
Bearer <JWT Token>
```

### Expected Response

```json
{
    "message":"This is protected data.",
    "user":"admin"
}
```

---

# 3. Admin Endpoint

### Endpoint

```
GET /api/Admin/dashboard
```

### Authorization

Requires

- Valid JWT Token
- Admin Role

### Expected Response

```json
{
    "message":"Welcome to the Admin Dashboard!",
    "user":"admin",
    "role":"Admin"
}
```

---

# 4. Unauthorized Request

Without JWT Token

```
401 Unauthorized
```

### Custom Response

```json
{
    "message":"Unauthorized. Invalid or expired token."
}
```

---

# 5. Expired Token

When an expired token is used, the application returns a custom unauthorized response and includes the `Token-Expired` response header.

---

## Swagger

Swagger is available at

```
http://localhost:5295/swagger
```

All endpoints were successfully tested through Swagger.

---

## Test Credentials

```
Username : admin

Password : admin123
```