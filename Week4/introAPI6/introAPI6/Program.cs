


// NET6 da startup yok. program.cs nin i�inde art�k startupdaki kodlar
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





//app.UseWelcomePage(); // hosgeldiniz sayfas� swaagger sayfan�n�n �st�ne yazd�g�m�z i�in bu sayfa ac�l�r 
// Configure the HTTP request pipeline.
// her talepte yap�lacak olan i�lemleri ayarl�yor app.Use...

if (app.Environment.IsDevelopment()) // geli�tirme ortam� ise swagger kullan 
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// S�ralama �nemli hangi i�lemler ilk yap�lacak gibi
// middleware: bir api'ye gelen b�t�n requestlerin bas�na gelecek herseyi y�netmenk i�in kulland�g�m�z yap�.
app.UseHttpsRedirection();
app.UseCors("AllowAll");
app.UseAuthorization();

app.MapControllers();

app.Run();
