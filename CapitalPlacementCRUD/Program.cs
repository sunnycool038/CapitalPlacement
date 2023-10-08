using CapitalPlacementCRUD.DataAccessLayer.DataAccess;
using CapitalPlacementCRUD.Domain.Interface;
using CapitalPlacementCRUD.Domain.Models;
using CapitalPlacementCRUD.Extensions;
using CapitalPlacementCRUD.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.Configure<credentials>(
builder.Configuration.GetSection("Credentials"));
builder.Services.AddSingleton<IProgramDetailsRecord, ProgramDetailsRecord>();
builder.Services.AddScoped<ITab1Service, Tab1Service>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.ConfigureMapping();
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

app.UseMiddleware(typeof(ExceptionMiddleware));

app.UseAuthorization();

app.MapControllers();

app.Run();
