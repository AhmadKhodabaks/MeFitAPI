using MeFitAPI.DataAccess;
using Microsoft.EntityFrameworkCore;
using Npgsql;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Retrieves database credentials from environment variables
string host = Environment.GetEnvironmentVariable("PGHOST");
string database = Environment.GetEnvironmentVariable("PGDATABASE");
string username = Environment.GetEnvironmentVariable("PGUSER");
string password = Environment.GetEnvironmentVariable("PGPASSWORD");
string port = Environment.GetEnvironmentVariable("PGPORT");

var databaseUrl = Environment.GetEnvironmentVariable("DATABASE_URL");
var databaseUri = new Uri(databaseUrl);
var userInfo = databaseUri.UserInfo.Split(':');
var constructor = new NpgsqlConnectionStringBuilder
{
    Host = databaseUri.Host,
    Port = databaseUri.Port,
    Username = userInfo[0],
    Password = userInfo[1],
    Database = databaseUri.LocalPath.TrimStart('/'),
};
string connectionString = constructor.ToString();


// Replaces placeholders in appsettings.json with actual values
//string connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
//    .Replace("{PGHOST}", host)
//    .Replace("{PGDATABASE}", database)
//    .Replace("{PGUSER}", username)
//    .Replace("{PGPASSWORD}", password)
//    .Replace("{PGPORT}", port);


builder.Services.AddDbContext<MeFitDbContext>(options =>
                options.UseNpgsql(connectionString));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
}
    app.UseSwagger();
    app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
