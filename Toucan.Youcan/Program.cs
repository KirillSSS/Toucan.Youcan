using Toucan.Youcan.Services;
using Toucan.Youcan.Services.Abstractions;
using Toucan.Youcan.Data.Abstraction;
using Toucan.Youcan.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Toucan.Youcan.Data;
using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseNpgsql("server=localhost; Port=5602; database=Scheduler; Username=postgres; password=justsomepassword");
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IUsersRepository, UserRepository>();
builder.Services.AddScoped<ITestService, ManualTestService>();
builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(builder =>
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader()
               .WithExposedHeaders("Content-Disposition")
               .WithExposedHeaders("Content-Length")
    );

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
