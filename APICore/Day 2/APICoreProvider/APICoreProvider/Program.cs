using APICoreProvider.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ITIEntity>(options =>
{
    options.UseSqlServer("Data Source=.;Initial Catalog=APCCoreTestDB;Integrated Security=true;trusted_connection=true;TrustServerCertificate=true; ");
});

builder.Services.AddCors(CorsOptions =>
{
    CorsOptions.AddPolicy("MyPolciy", CorsBuilder =>
    {
        CorsBuilder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
        
    });

    //CorsOptions.AddPolicy("PlanB", CorsBuilder =>
    //{
    //    CorsBuilder.WithOrigins("http").WithMethods("");
    //});
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.UseStaticFiles();
app.UseCors("MyPolciy");

app.MapControllers();

app.Run();
