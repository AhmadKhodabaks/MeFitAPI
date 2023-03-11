using MeFitAPI.DataAccess;
using MeFitAPI.MappingProfiles;
using MeFitAPI.Repository;
using MeFitAPI.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using Npgsql;
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
        policy =>
        {
            policy.WithOrigins("http://localhost:3000")
            .AllowAnyHeader()
            .AllowAnyMethod();
        });
});

builder.Services.AddControllers(options =>
{
    //options.ReturnHttpNotAcceptable = true;
}).AddNewtonsoftJson();

string connectionString = ConnectionHelper.GetConnectionString(builder.Configuration);
builder.Services.AddDbContext<MeFitDbContext>(options =>
                options.UseNpgsql(connectionString));
builder.Services.AddScoped<IProfileRepository, ProfileRepository>();
builder.Services.AddAutoMapper(typeof(MappingConfig));
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
else
{
app.UseSwagger();
    app.UseSwaggerUI(options => {
        options.SwaggerEndpoint("swagger/v1/swagger.json", "MeFitAPIV1");
        options.RoutePrefix = String.Empty; });
}

app.UseHttpsRedirection();

app.UseCors(MyAllowSpecificOrigins);

app.UseAuthorization();

app.MapControllers();

app.Run();
