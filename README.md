
# 🚀 My First .NET 10 Web API

My first backend application built with **.NET 10**, **C# 14**, and **ASP.NET Core Minimal APIs** using **Visual Studio Community**.

This project demonstrates how modern .NET applications are structured using concepts like **Dependency Injection**, **Interfaces**, **LINQ**, and **Exception Handling** to create clean and maintainable code.

---

## ✨ Features

* Filter prices greater than 50
* Sort results in ascending order
* Service-based architecture
* Dependency Injection
* Interface implementation
* LINQ for data filtering
* Exception handling with try-catch
* Minimal APIs

---

## 🛠 Tech Stack

* C#
* .NET 10
* ASP.NET Core Minimal API
* Visual Studio Community
* LINQ

---

## 📂 Project Structure

```text
InternshipFirstApp
│
├── .github
│   └── workflows
│
├── InternshipFirstApp
│   ├── Program.cs
│   ├── appsettings.json
│   ├── appsettings.Development.json
│   ├── Properties
│   │   └── launchSettings.json
│   └── ...
│
├── .gitattributes
├── .gitignore
├── InternshipFirstApp.sln
└── README.md
```

---

## 📋 API Endpoint

### GET `/filter-prices`

Returns all prices greater than 50 sorted in ascending order.

### Example Request

```http
GET /filter-prices
```

### Example Response

```json
[
  75,
  90,
  150
]
```

---

## 🧠 Concepts Practiced

### 1. Dependency Injection

```csharp
builder.Services.AddScoped<IPriceService, PriceService>();
```

This tells .NET to automatically provide a `PriceService` object whenever an `IPriceService` is required.

---

### 2. Interface

```csharp
public interface IPriceService
{
    List<int> GetExpensivePrices();
}
```

Interfaces define a contract that implementing classes must follow.

---

### 3. Exception Handling

```csharp
try
{
    var clearPrices = worker.GetExpensivePrices();
    return Results.Ok(clearPrices);
}
catch(Exception ex)
{
    return Results.BadRequest(ex.Message);
}
```

This ensures that unexpected errors are handled gracefully.

---

### 4. LINQ

```csharp
var filteredList = rawPrices
                    .Where(p => p > 50)
                    .OrderBy(p => p)
                    .ToList();
```

LINQ provides a concise and readable way to query and manipulate collections.

---

## ⚙️ How It Works

1. User sends a request to `/filter-prices`.
2. The route receives the request.
3. ASP.NET Core injects the `IPriceService`.
4. The service processes the data using LINQ.
5. Filtered prices are returned as JSON.
6. Any errors are handled using try-catch.

---

## ▶️ Running the Application

### Clone the repository

```bash
git clone <repository-url>
```

### Navigate to the project folder

```bash
cd InternshipFirstApp
```

### Run the application

```bash
dotnet run
```

### Open in browser

```text
https://localhost:7038/filter-prices
```

---

## 🌱 Learning Outcomes

Through this project, I learned:

* ASP.NET Core Minimal APIs
* Dependency Injection
* Interfaces
* LINQ
* Exception Handling
* Service-based architecture
* HTTP Responses
* Clean and maintainable code

---

## 👩‍💻 Author

**Jahnvi Srivastava**

---

⭐ If you found this project useful, feel free to star the repository!


