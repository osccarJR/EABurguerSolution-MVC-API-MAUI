using APIBurguerEA.Controllers;
using APIBurguerEA.Data;  // Asegúrate de tener este using si tienes DbContext en otro archivo
using Microsoft.EntityFrameworkCore;  // Asegúrate de tener este using para DbContext
using Microsoft.OpenApi.Models;  // Asegúrate de tener este using para Swagger

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "APIBurguerEA", Version = "v1" });
});

// Register your DbContext with dependency injection
builder.Services.AddDbContext<EaburguerSolutionContextContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "APIBurguerEA v1"));
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapBurguerEndpoints();

app.Run();
