// ======================================================================
// PART 1: THE RUNNING CODE (Must always be at the absolute top of the file)
// ======================================================================

var builder = WebApplication.CreateBuilder(args);

// Register our service tool
builder.Services.AddScoped<IPriceService, PriceService>();

var app = builder.Build();

// Setup our route button
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

// Turn the machine on
app.Run();


// ======================================================================
// PART 2: THE BLUEPRINTS & WORKERS (Must always be at the absolute bottom)
// ======================================================================

public interface IPriceService
{
    List<int> GetExpensivePrices();
}

public class PriceService : IPriceService
{
    public List<int> GetExpensivePrices()
    {
        var rawPrices = new List<int> { 90, 12, 150, 5, 45, 75, 30 };
        var filteredList = rawPrices.Where(p => p > 50).OrderBy(p => p).ToList();
        return filteredList;
    }
}