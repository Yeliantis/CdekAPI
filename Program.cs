using AutoMapper;
using CdekAPI.Actions;
using CdekAPI.Actions.Contracts;
using CdekAPI.Configuration;
using CdekAPI.Services;
using CdekAPI.Services.Contracts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IAuthorization, Authorization>();
builder.Services.AddScoped<ICostCalculation, CostCalculation>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddSingleton<Mapper>(provider => AutoMapperConfiguration.CreateMapper());
builder.Services.AddScoped<IGetInfoAction, GetInfoAction>();

builder.Services.AddAutoMapper(typeof(AutoMapperConfiguration));
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
