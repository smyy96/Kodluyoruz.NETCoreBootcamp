using Catalog.Business;
using Catalog.Business.Mapping;
using Catalog.DataAccess.Data;
using Catalog.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using Catalog.API.Extension;
using Catalog.API.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IProductService , ProductService>();
builder.Services.AddScoped<IProductRepository, EFProductRepository>(); // veritabaný

builder.Services.AddAutoMapper(typeof(MapProfile));
builder.Services.AddDbContext<CatalogDbContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("db")));
builder.Services.AddCors(opt => opt.AddPolicy("allow", cpb =>
{
    cpb.AllowAnyOrigin();
    cpb.AllowAnyMethod();
    cpb.AllowAnyHeader();
}));

builder.Services.AddAuthentication("Basic").AddScheme<>

var app = builder.Build();

app.UseProductIsExixtTestPage();// exception metot ile middleware

app.Use((cnt, next) =>
{
    Console.WriteLine($"{cnt.Request.Path} adresinde, {cnt.Request.Method} talebi geldi");
    return next();
});


//app.UseMiddleware<CheckBrowserIsIEMiddleware>(); // IE var mi
//app.UseMiddleware<ResponseEditingMiddleware>();  // varsa 400 gönder
//app.UseMiddleware<RedirectMiddleware>(); // 400 dönüyorsa sayfaya yönlendir
app.UseCheckIE();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseCors("allow");//html dosyasýný acmak


app.UseAuthentication();
app.UseAuthorization(); // yetki kontrolü

app.MapControllers();

app.Run();
