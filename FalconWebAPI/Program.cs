using Falcon.Application;
using Falcon.Core.Interface;
using Falcon.Infrastructure.Data;
using Falcon.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var db =builder.Services.AddDbContext<FalconContext>(opts => opts.UseSqlServer(builder.Configuration["ConnectionStrings:DefaultConnection"]));

//builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<ICountryRepository, CountryRepository>();
builder.Services.AddTransient<IWeatherTypeRepository, WeatherTypeRepository>();
builder.Services.AddTransient<IWeatherEventRepository, WeatherEventRepository>();

builder.Services.AddCors(x => x.AddPolicy("AllowOrigin", builder => builder.WithOrigins("http://localhost:4200")));
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
app.UseCors("AllowOrigin");
app.Run();
