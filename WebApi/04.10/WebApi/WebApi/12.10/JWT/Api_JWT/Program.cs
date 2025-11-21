using Api_JWT.Models.Context;
using Api_JWT.Services.Abstracts;
using Api_JWT.Services.Concretes;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//DbContext
builder.Services.AddDbContext<NorthwindContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//Scoped
builder.Services.AddScoped<IEmployeeService, EmployeeService>();

//Cors Policy
builder.Services.AddCors(options =>
{
    options.AddPolicy("DefaultCors", cors =>
    {
        cors.AllowAnyHeader();
        cors.AllowAnyMethod();
        cors.AllowAnyOrigin();
    });
});


//JWT Configuration
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
    {
        //JWT oluþturabilmek için bir takým parametrelere ihtiyacýmýz bulunmaktadýr. 

        //Yayýncý (Issuer)
        ValidateIssuer = true, //yayýncý doðrulamasý aktif.

        //Alýcý (Audience)
        ValidateAudience=true, //kullanýcý (alýcý) doðrulamasý aktif

        //Süre (Lifetime)
        ValidateLifetime = true,

        //Doðrulama Anahtarý (IssuerSignKey)
        ValidateIssuerSigningKey = true,

        //Geçerli Yayýncý (ValidIssuer)
        ValidIssuer = builder.Configuration["JWT:Issuer"],

        //Geçerli Alýcý  (ValidAudience)
        ValidAudience= builder.Configuration["JWT:Audience"],

        //Geçerli Anahtar: (Secret key)
        IssuerSigningKey=new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:Key"]))

    };
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("DefaultCors");
app.UseRouting();


app.UseHttpsRedirection();



app.UseAuthorization();

app.MapControllers();

app.Run();
