using MVC_ScopedTransientSingleton.Services.Abstracts;
using MVC_ScopedTransientSingleton.Services.Concretes;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Transient: Transient olarak tanýmlanan bir instance ile ne kadar istekte bulunursak o kadar RAM üzerinde instance alýnýr.
builder.Services.AddTransient<ITransientService, OperationService>();

//Scoped: Client'a yapýlan her istekte bir adet instance oluþturur ve yoluna o instance ile devam eder.
builder.Services.AddScoped<IScopedService, OperationService>(); 

//Singleton
builder.Services.AddSingleton<ISingletonService, OperationService>();

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

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
