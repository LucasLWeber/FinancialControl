using FinancialControl.Application.UseCases.UserUseCases;
using FinancialControl.Application.Validators;
using FinancialControl.Domain.Ports;
using FinancialControl.Infrastructure.Adapters;
using FinancialControl.Infrastructure.Data;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Para executar/atualizar as migrations
// dotnet ef migrations add InitialCreate -p FinancialControl.Infrastructure -s FinancialControl.Api/FinancialControl.Api.csproj
// dotnet ef database update -p FinancialControl.Infrastructure -s FinancialControl.Api/FinancialControl.Api.csproj
builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<CreateUserService>();

builder.Services.AddValidatorsFromAssemblyContaining<UserDtoValidator>();
builder.Services.AddFluentValidationAutoValidation();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.Use(async (context, next) =>
{
    context.Request.Path = context.Request.Path.Value.ToLower();
    await next.Invoke();
});

app.UseAuthorization();

app.MapControllers();

app.Run();
