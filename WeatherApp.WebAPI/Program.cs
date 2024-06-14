using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<WeatherDb>(options => options.UseInMemoryDatabase("WeatherDb5"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Add
app.MapPost("/favorites", async (WeatherDb db, FavoriteCity city) => {
    await db.FavoriteCities.AddAsync(city);
    await db.SaveChangesAsync();
    return Results.Created($"/favorites/{city.CityId}", city);
})
.WithName("AddFavorite")
.WithOpenApi();

// Get
app.MapGet("/favorites", async (WeatherDb db) =>
{
    var results = await db.FavoriteCities.ToListAsync();
    return results;
})
.WithName("GetFavorities")
.WithOpenApi();

// Delete
app.MapDelete("/favorites", async (WeatherDb db, int cityId) => {
   var city = await db.FavoriteCities.FindAsync(cityId);
   if (city is null)
   {
      return Results.NotFound();
   }

   db.FavoriteCities.Remove(city);
   await db.SaveChangesAsync();
   return Results.Ok();
})
.WithName("DeleteFavorite")
.WithOpenApi();

app.Run();

public class FavoriteCity
{
    [Key]
    public int CityId { get; set; }
    public string? CityName { get; set; }
}

class WeatherDb : DbContext
{
    public WeatherDb(DbContextOptions options) : base(options) { }

    public DbSet<FavoriteCity> FavoriteCities { get; set; } = null!;
}