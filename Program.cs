using DAFramework.Models;
using DAFramework.Services;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddRazorPages();



builder.Services.AddDbContext<MyWebContext>(options => {
    IConfiguration configuration = builder.Configuration;
    string connectString = configuration.GetConnectionString("MyWebContext");
    options.UseSqlServer(connectString);
});



builder.Services.Configure<RazorViewEngineOptions>(options => {
    options.ViewLocationFormats.Add("/Areas/{1}/{0}" + RazorViewEngine.ViewExtension);
});

builder.Services.AddSingleton<ProductService, ProductService>();

builder.Services.AddSingleton<PlanetService, PlanetService>();



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
app.UseAuthentication();

app.MapControllers();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();


app.Run();
