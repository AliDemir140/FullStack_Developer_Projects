
//Bu bir web uygulamasý baþlatma kodudur.
using Microsoft.EntityFrameworkCore;
using WebApiCRUD.Models;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("FatihConnection");

//Services
builder.Services.AddControllers();//controller'larýn barýndýðý yer

//DbContext
builder.Services.AddDbContext<NorthwindContext>(options=>options.UseSqlServer(connectionString));

//CORS Policy
builder.Services.AddCors(options =>
{
    options.AddPolicy("NorthwindCors", policy =>
    {
        //Hangi adresten istekler kabul edilecek?
        policy.AllowAnyOrigin();//bütün kaynaklardan gelecek olan istekler
        //Hangi fiillere izin verilecek (Get, Post, Put, Delete)
        policy.AllowAnyMethod(); //bütün fiiler
        //Hangi Header bilgileri dahil edilecek?
        policy.AllowAnyHeader();//bütün header bilgileri
    });
});


//servislerin barýndýðý yer
var app = builder.Build();

//Cors
app.UseCors("NorthwindCors");


//aþaðýdaki metot rotalama iþlemini yapar
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();//controller'larýn barýndýðý yer
});


//middleware'lerin barýndýðý yer
app.Run();
