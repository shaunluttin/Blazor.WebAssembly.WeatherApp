var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Add
app.MapPost("/favorites", () => {

})
.WithName("AddFavorite")
.WithOpenApi();

// Delete
app.MapDelete("/favorites", () => {

})
.WithName("DeleteFavorite")
.WithOpenApi();

// Get
app.MapGet("/favorites", () =>
{
    var forecast =  Enumerable.Range(1, 5).Select(index =>
        new FavoriteCity
        (
            "Vancouver"
        ))
        .ToArray();

    return forecast;
})
.WithName("GetFavorities")
.WithOpenApi();

app.Run();

// record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
// {
//     public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
// }

record FavoriteCity(string CityName)
{
}