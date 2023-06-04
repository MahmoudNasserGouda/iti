var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.Map("/Admin", (app2) =>
{
    app2.Run(async (context) =>
    {
        await context.Response.WriteAsync("<h1>Welcome Admin<h1/>");
    });
});

app.Use(async (context, next) =>
{
    if (context.Request.QueryString.Value == "?ITI")
        await next();
    else
        await context.Response.WriteAsync("Not Authorized");
});

app.Run(async (context) =>
{
    await context.Response.WriteAsync("<h1>Hello world!<h1/>");
});

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
