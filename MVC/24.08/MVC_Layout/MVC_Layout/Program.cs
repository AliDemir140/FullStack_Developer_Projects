var builder = WebApplication.CreateBuilder(args);
//Servisler
//Projenin bir mvc projesi haline gelmesi için aþaðýdaki servis tanýmlanmasý gerekmektedir.

//builder.Services.AddMvc(); //opsiyonel
builder.Services.AddControllersWithViews();


var app = builder.Build();
//pipeline

//wwwroot klasörüne ulaþým için UseStaticFiles();
app.UseStaticFiles();

//Route kullanýmý
app.UseRouting();
app.UseEndpoints(endpoint =>
{
    endpoint.MapDefaultControllerRoute();
    //eðer proje içerisinde bir controller varsa ve bu controller adý HomeController ise içerisinde de Index adýn bir Action metot tanýmlýysa varsayýlan olarak o action'ý tetikler. Arkaplanda istekleri kabul etmek için URL'de aþaðýdaki formatý bekler.
    //https://localhost:7280/Controller/Action/id
});

app.Run();
