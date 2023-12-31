using Microsoft.EntityFrameworkCore;
using WarehouseWebService.Common.Extensions.Configurations;
using WarehouseWebService.Infrastructure;
using WarehouseWebService.Infrastructure.Database;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<WarehouseDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("WarehouseConnection"));
});

builder.Services.AddConfiguredAutoMapper();
builder.Services.AddApplicationServices();

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