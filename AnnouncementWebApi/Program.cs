using AnnouncementWebApi.Services;
using Data;
using Data.Data;
using Data.Entities;
using Data.FluentValidation;
using FluentValidation;
using FluentValidation;
using Interfaces;
using Microsoft.EntityFrameworkCore;
using NLog.Web;
using Repository;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddDbContext<RepositoryContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("sqlConnection")));
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
builder.Services.AddSingleton<ILoggerService, LoggerService>();
builder.Services.AddAutoMapper(typeof(MappingProfile));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Logging.ClearProviders();
builder.WebHost.UseNLog();
builder.Services.AddScoped<IValidator<Announcement>, AnnoucementValidation>();
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
