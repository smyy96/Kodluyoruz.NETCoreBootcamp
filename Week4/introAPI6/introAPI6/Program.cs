


// NET6 da startup yok. program.cs nin içinde artýk startupdaki kodlar
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//builder.Services ile 
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(opt=>opt.AddPolicy("AllowAll",p=> 
{
    p.AllowAnyOrigin();
    p.AllowAnyMethod();
    p.AllowAnyHeader();

}));

var app = builder.Build();





//app.UseWelcomePage(); // hosgeldiniz sayfasý swaagger sayfanýnýn üstüne yazdýgýmýz için bu sayfa acýlýr 
// Configure the HTTP request pipeline.
// her talepte yapýlacak olan iþlemleri ayarlýyor app.Use...

if (app.Environment.IsDevelopment()) // geliþtirme ortamý ise swagger kullan 
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Sýralama önemli hangi iþlemler ilk yapýlacak gibi
// middleware: bir api'ye gelen bütün requestlerin basýna gelecek herseyi yönetmenk için kullandýgýmýz yapý.
app.UseHttpsRedirection();
app.UseCors("AllowAll");
app.UseAuthorization();

app.MapControllers();

app.Run();
