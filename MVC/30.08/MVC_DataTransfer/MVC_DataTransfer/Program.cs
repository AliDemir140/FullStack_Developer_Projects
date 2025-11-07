var builder = WebApplication.CreateBuilder(args);
//Services
builder.Services.AddControllersWithViews();


var app = builder.Build();

//App pipeline


app.UseRouting();
app.UseStaticFiles();//wwwroot

app.UseEndpoints(endpoints =>
{
    endpoints.MapDefaultControllerRoute();
    //Home/Index/id?
});


app.Run();
