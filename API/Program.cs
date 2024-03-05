using Application.MediatR;
using Application.Services;
using Infrastructure.Persistence;
using Infrastructure.Repository;
using Infrastructure.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using MediatR;
using System.Reflection;
using API.Middleware;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<CarService>();

// Assuming CarRepository implements ICarRepository, register it here
builder.Services.AddTransient<ICarRepository, CarRepository>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add Middleware


builder.Services.AddDbContext<Context>(opts =>
    opts.UseNpgsql("Host=localhost;Database=SportCarsDb;Username=root;Password=password"));

builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Program).Assembly));


builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "AllowSpecificOrigin",
        builder =>
        {
            builder.WithOrigins("http://localhost:3000") 
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
});


builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseExceptionHandler( _ => { });

app.UseHttpsRedirection();

app.UseMiddleware<ExceptionHandlingMiddleware>();

app.UseCors("AllowSpecificOrigin"); // Apply the CORS policy

app.UseAuthorization();

app.MapControllers();

app.Run();
