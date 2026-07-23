# RetailInventory - EF Core 8.0 Hands-on Reference

## Project Information

- **Project Name:** RetailInventory
- **Framework:** .NET 8
- **Database:** SQL Server Express
- **ORM:** Entity Framework Core 8
- **Database Name:** RetailInventoryDB

---

# Lab 1 – Understanding ORM

### Objective
Created a .NET Console Application and installed Entity Framework Core packages.

### Commands

```bash
dotnet new console -n RetailInventory
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Design
```

---

# Lab 2 – Database Context

### Implemented

- Category Model
- Product Model
- AppDbContext
- SQL Server Connection

```csharp
public DbSet<Category> Categories { get; set; }

public DbSet<Product> Products { get; set; }

protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    optionsBuilder.UseSqlServer(
        "Server=.\\SQLEXPRESS;Database=RetailInventoryDB;Trusted_Connection=True;TrustServerCertificate=True");
}
```

---

# Lab 3 – Migrations

### Commands Used

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

Result:

- Created SQL Server Database
- Generated Migration Files

---

# Lab 4 – Insert Initial Data

### Implemented

```csharp
var electronics = new Category { Name = "Electronics" };
var groceries = new Category { Name = "Groceries" };

context.Categories.AddRange(electronics, groceries);

context.Products.AddRange(
    new Product
    {
        Name="Laptop",
        Price=75000,
        Category=electronics
    },

    new Product
    {
        Name="Rice Bag",
        Price=1200,
        Category=groceries
    });

await context.SaveChangesAsync();
```

---

# Lab 5 – Retrieve Data

### Implemented

- Retrieve all products
- Find by Id
- FirstOrDefault

```csharp
var products = await context.Products.ToListAsync();

var product = await context.Products.FindAsync(1);

var expensive = await context.Products
    .FirstOrDefaultAsync(p => p.Price > 50000);
```

---

# Lab 6 – Update & Delete

### Update Product

```csharp
product.Price = 70000;

await context.SaveChangesAsync();
```

### Delete Product

```csharp
context.Products.Remove(product);

await context.SaveChangesAsync();
```

---

# Lab 7 – LINQ Queries

### Filtering

```csharp
.Where(p => p.Price > 1000)
```

### Sorting

```csharp
.OrderByDescending(p => p.Price)
```

### Projection

```csharp
.Select(p => new
{
    p.Name,
    p.Price
});
```

---

# Lab 8 – Schema Changes

### Added Property

```csharp
public int Stock { get; set; }
```

### Migration

```bash
dotnet ef migrations add AddStockColumn

dotnet ef database update
```

---

# Lab 9 – Data Seeding

### Seeded Categories

```csharp
Electronics

Groceries
```

### Seeded Products

```csharp
Laptop

Rice Bag
```

Used EF Core to insert initial records into the database.

---

# Lab 10 – Loading Strategies

### Eager Loading

```csharp
.Include(p => p.Category)
```

### Explicit Loading

```csharp
await context.Entry(product)
    .Reference(p => p.Category)
    .LoadAsync();
```

---

# Lab 11 – Relationships

## One-to-One

```csharp
Product

↓

ProductDetail
```

Configured using

```csharp
.HasOne()
.WithOne()
.HasForeignKey<ProductDetail>()
```

## Many-to-Many

```text
Product

↕

Tag
```

Implemented using EF Core navigation properties.

---

# Lab 12 – DTO

Created

```text
ProductDTO
```

Projection

```csharp
.Select(p => new ProductDTO
{
    Name = p.Name,
    CategoryName = p.Category.Name
});
```

---

# Lab 13 – Query Optimization

### Read Only Query

```csharp
.AsNoTracking()
```

### Compiled Query

```csharp
EF.CompileAsyncQuery(...)
```

---

# Lab 14 – Batch Processing

Updated multiple records together.

```csharp
foreach(var product in products)
{
    product.Stock += 10;
}

await context.SaveChangesAsync();
```

*(Bulk update concept demonstrated using EF Core.)*

---

# Lab 15 – Optimistic Concurrency

Added

```csharp
[Timestamp]

public byte[]? RowVersion { get; set; }
```

Handled

```csharp
try
{
    await context.SaveChangesAsync();
}
catch(DbUpdateConcurrencyException)
{
    Console.WriteLine("Concurrency conflict detected.");
}
```

Migration

```bash
dotnet ef migrations add AddRowVersion

dotnet ef database update
```

---

# Technologies Used

- C#
- .NET 8
- Entity Framework Core 8
- SQL Server Express
- SQL Server Management Studio (SSMS)
- LINQ
- Migrations
- Code First Approach

---

# Outcome

Successfully implemented all Entity Framework Core hands-on labs in a single **RetailInventory** project by progressively extending the application with:

- Entity Models
- DbContext
- SQL Server Connectivity
- Migrations
- CRUD Operations
- LINQ Queries
- Schema Evolution
- Data Seeding
- Loading Strategies
- Entity Relationships
- DTO Projection
- Query Optimization
- Batch Updates
- Optimistic Concurrency

This file serves as a concise implementation reference for evaluation.