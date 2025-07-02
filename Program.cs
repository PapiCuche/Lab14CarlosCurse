using ExportExcel.Application;
using ExportExcel.Application.Reports.Queries;
using ExportExcel.Configuration;
using ExportExcel.Domain.Interfaces;
using ExportExcel.Infrastructure;
using ExportExcel.Infrastructure.Excel;
using ExportExcel.Infrastructure.Infrastructure.Persistence;
using ExportExcel.Infrastructure.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Agregar servicios al contenedor
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configuración de DbContext
builder.Services.AddDbContext<LinqExampleDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// Configuración de MediatR (compatible con .NET 8 y versión 11.x)
builder.Services.AddMediatR(typeof(GetClientSalesReportHandler).Assembly);

// Servicios de aplicación
builder.Services.AddApplicationServices(builder.Configuration);

// Construcción de la aplicación
var app = builder.Build();

// Middleware
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();

// Rutas
app.MapControllers();

// Ejecución
app.Run();