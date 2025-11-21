using Api_BasicAuth.Models.Context;
using Api_BasicAuth.Schemes;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//connectionstring
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<AuthDbContext>(options => options.UseSqlServer(connectionString));

//Identity Service
builder.Services.AddIdentity<IdentityUser,IdentityRole>()
    .AddEntityFrameworkStores<AuthDbContext>();

//HTTP içerisinde tanýmlý olan "Authorize" özniteliðine sahip bilgileri yakalayabilmek için bir custom authentication tanýmlamamýz gerekmektedir.
builder.Services.AddAuthentication("BasicAuth")
    .AddScheme<AuthenticationSchemeOptions, BasicAuth>("BasicAuth", null);

builder.Services.AddCors(cors =>
{
    cors.AddPolicy("defaultCors", x =>
    {
        x.AllowAnyOrigin();
        x.AllowAnyHeader();
        x.AllowAnyMethod();
    });
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseCors("defaultCors");

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();



app.MapControllers();

app.Run();
