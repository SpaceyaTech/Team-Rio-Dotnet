using Microsoft.EntityFrameworkCore;
using SpaceYaTech.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connectionString = builder.Configuration.GetConnectionString("Database");
var serverVersion = new MariaDbServerVersion(new Version(10, 5));
builder.Services.AddDbContextPool<DatabaseContext>(
    opt => opt.UseMySql(connectionString, serverVersion)
    .EnableSensitiveDataLogging()
    .EnableDetailedErrors());

builder.Services.AddControllers();
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

app.UseAuthorization();

app.MapControllers();

// Run any pending migrations automatically each time the app starts.
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var context = services.GetRequiredService<DatabaseContext>();
        context.Database.Migrate();
    }
    catch (Exception ex)
    {

        Console.WriteLine("Database Migration Error");
        Console.WriteLine(ex.Message);
    }
}

app.Run();
