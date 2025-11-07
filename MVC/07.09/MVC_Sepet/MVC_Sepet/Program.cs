using Microsoft.EntityFrameworkCore;
using MVC_Sepet.Models.Northwind;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//appsettings.json ieçrisinde tanýmlanan anahtar (key) ulaþabilmek için configuration özelliðini kullanmamýz gerekmektedir.
string connectionString=builder.Configuration.GetConnectionString("LocalConnection");



//Services
//DbContext Dependency
builder.Services.AddDbContext<NorthwindContext>(options => options.UseSqlServer(connectionString));


//Session Service
builder.Services.AddSession(x =>
{
    x.IdleTimeout = TimeSpan.FromMinutes(2);
    x.Cookie = new CookieBuilder
    {
        Name = "sepet_session"
    };
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

//servis tarafýnda tanýmlanan session'ý kullanýma aldýk.
app.UseSession();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
