var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


app.UseDefaultFiles(); //eðer baþlangýçta index.html açýlmasýný istiyorsak bu baþta olmasý lazým.
app.UseStaticFiles();//wwwroot eriþime açýk hale getirir.


app.Run();
