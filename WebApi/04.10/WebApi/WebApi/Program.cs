using WebApi.DummyData;
using WebApi.Models;

var builder = WebApplication.CreateBuilder(args);
//Services
//Api Service




var app = builder.Build();

//Minamal API
//endpoints: ulaþým noktasý.
app.MapGet("/", () => "Hello World!");
app.MapGet("/contact", () =>
{
    //Contact nesnesini Html'den baðýmsýz oalcak þekilde browser üzerinde gösterilecek.

    Contact contact = new Contact
    {
        Firstname="Fatih",
        Lastname = "Günalp",
        Content = "örnek iletiþim yazýsý"
    };



    if (contact.Firstname != null)
    {
        //success
        return Results.Ok(contact);
    }
    else
    {
        //notfound
        return Results.NotFound("Ad boþ oalrak tanýmlý");
    }


});

//bütün ürünler (GET)
app.MapGet("/products", () => ProductData.GetProducts());

//ýd'e göre tekil ürün. (GET)
app.MapGet("/products/{id}", (int id) =>
{
    var product = ProductData.GetProducts().FirstOrDefault(x => x.Id == id);

    if (product != null)
    {
        //status code success
        return Results.Ok(product);
    }
    else
    {
        ///status code notfound
        return Results.NotFound($"{id} ait bir ürün bulunamadý");
    }
});

//ürün ekleme (POST)
app.MapPost("/products", (Product product) =>
{
    bool result = ProductData.AddProduct(product);
    if (result)
    {
        //200
        return Results.Ok("ürün eklendi");
    }
    else
    {
        //400
        return Results.BadRequest("hatalý istek");
    }
});


//ürün güncelleme (PUT)
app.MapPut("/products/{id}", (int id, Product updated) =>
{
    var result=ProductData.UpdateProduct(updated);
    if (result)
    {
        return Results.Ok("ürün güncellendi");
    }
    else
    {
        //400
        return Results.BadRequest("hatalý istek");
    }
});

//ürün kaldýrma (DELETE)
app.MapDelete("/products/{id}", (int id) =>
{
    var result = ProductData.DeleteProduct(id);
    if (result)
    {
        return Results.Ok("ürün silindi");
    }
    else
    {
        //400
        return Results.BadRequest("hatalý istek");
    }
});

app.Run();
