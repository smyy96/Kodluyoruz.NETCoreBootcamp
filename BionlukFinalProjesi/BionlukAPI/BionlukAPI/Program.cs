using Bionluk.Business;
using Bionluk.Business.Mapping;
using Bionluk.DataAccess;
using Bionluk.DataAccess.Data;
using Bionluk.DataAccess.Migrations;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUserService, UserService>();//UserService bellekte bekletiyor kullanýlmak için
builder.Services.AddScoped<IUserRepository, EFUserRepository>();

builder.Services.AddAutoMapper(typeof(MapProfile));//MapProfile ý automapper a ekledik
builder.Services.AddDbContext<BionlukDbContext>(op => op.UseSqlServer(builder.Configuration.GetConnectionString("db")));



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
