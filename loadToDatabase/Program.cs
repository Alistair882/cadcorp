using loadToDatabase.Extensions;
using loadToDatabase.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplicationServices(builder.Configuration);

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    await Seed.SeedAddresses(context);
}

app.MapGet("/", () => "Hello World!");

await app.RunAsync();
