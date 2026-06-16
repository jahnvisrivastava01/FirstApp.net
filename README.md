
# 🚀 My First .NET 10 Web API

Welcome to my very first production-ready backend application built with **.NET 10** and **C# 14** inside Visual Studio Community! 

This project isn't just lines of code—it is built like a **digital vending machine** using professional architecture principles that commercial development teams use every single day.

---

## 🧭 How the Data Flows (The Vending Machine Metaphor)

When a user visits this API, they are pressing a button on a vending machine. Here is how the application handles it behind the scenes:


```

[ User Browser ]  --->  ( 1. The Route / The Gatekeeper )
|
v
( 2. The Service / The Brain )
|
v
( 3. LINQ & Exception Safety Nets )

```

1. **The Route (`/filter-prices`):** Listens for the user's click and acts as the gatekeeper.
2. **The Service Tool (`IPriceService`):** The brain layer that holds the business logic.
3. **LINQ & Try-Catch:** Instantly filters the data and acts as a safety net so the server never crashes.

---

## 🛠️ Deep Dive: Understanding the Code Architecture

Modern .NET 10 uses a strict structure in the main `Program.cs` file. The computer reads code from top to bottom, split into distinct execution zones:

### 🎛️ Zone 1: Turning on the Machine Power
```csharp
var builder = WebApplication.CreateBuilder(args);

```

This gathers all the internal configurations and gets the framework engine ready.

### 🤝 Zone 2: Dependency Injection (Hiring the Worker)

Instead of forcing our routes to build their own tools, we register our service blueprint at the top:

```csharp
builder.Services.AddScoped<IPriceService, PriceService>();
var app = builder.Build();

```

* **Plain English:** *"Hey .NET, whenever an endpoint route asks for the `IPriceService` blueprint, automatically hand it the concrete `PriceService` worker class."*

### ⚡ Zone 3: The Route Button & Safety Net

```csharp
app.MapGet("/filter-prices", (IPriceService worker) => 
{
    try 
    {
        var clearPrices = worker.GetExpensivePrices();
        return Results.Ok(clearPrices);
    }
    catch (Exception ex)
    {
        return Results.BadRequest("An error occurred: " + ex.Message);
    }
});

```

* **The Nickname Rule:** `(IPriceService worker)` tells the route to accept a tool of type `IPriceService` and give it the temporary nickname `worker`.
* **The Safety Net:** The `try-catch` block intercepts any unexpected failures gracefully, returning a standard `400 Bad Request` instead of crashing the entire system console.

### 🔍 Zone 4: LINQ (High-Speed Data Filtering)

At the bottom of the file, our worker utilizes C# **LINQ** to sort arrays instantly without messy, slow loops:

```csharp
var filteredList = rawPrices.Where(p => p > 50).OrderBy(p => p).ToList();

```

* `p => p > 50` translates to: *"For every price `p` inside the collection, keep it only **WHERE** `p` is greater than 50, and then sort them from lowest to highest."*

---

## 🚀 How to Run and Test Localhost

1. Open this solution in **Visual Studio Community**.
2. Click the green **Play/Debug** arrow button at the top center.
3. Keep the application running in the background.
4. Open your web browser (Chrome/Edge) and navigate directly to your local port endpoint:
```text
https://localhost:7038/filter-prices

```


5. **Expected JSON Output:**
```json
[75, 90, 150]

```
### How to add this to your project right now:
1. In Visual Studio, go to your **Solution Explorer** on the right side.
2. Look for a file named `README.md`. (If it's not there, right-click your project name -> **Add** -> **New Item** -> choose a Text File and name it `README.md`).
3. Paste this text inside, save the file, and then look at your Git changes tab to push it up to your GitHub repository! 
