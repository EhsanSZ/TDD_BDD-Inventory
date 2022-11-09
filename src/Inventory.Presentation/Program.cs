using Inventory.Application;
using Inventory.Application.Contract;
using Inventory.Domain;
using Inventory.Infrastructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IInventoryService, InventoryService>();
builder.Services.AddTransient<IInventoryRepository, InventoryRepository>();

var config = builder.Configuration;

var connectionString = config.GetConnectionString("InventoryDb");
builder.Services
    .AddDbContext<InventoryContext>(builder =>
        builder.UseSqlServer(connectionString));


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

app.Run();
