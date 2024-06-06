using EncantoPaisa.DAL;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

using EncantoPaisa.Domain.Interfaces;
using EncantoPaisa.Domain.Services;

var builder = WebApplication.CreateBuilder(args);

// Agregar servicios al contenedor.
builder.Services.AddControllers();

// Configuración de la base de datos
// Configuración de la base de datos
builder.Services.AddDbContext<DataBaseContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Registrar el servicio IEventsService
builder.Services.AddScoped<IEventsService, EventsService>();

// Configurar Swagger para documentación de API
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configurar el pipeline de solicitudes HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();