using System.Net;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
var services = builder.Services;


services.AddDbContext<AppDbContext>(
    options => {
        string? connectionString = builder.Configuration.GetConnectionString("AppMvcConnectionStrings");
        options.UseSqlServer(connectionString);
    }
);
services.AddSingleton<ProductServices>();
services.AddSingleton<PlanetService>();
services.AddRazorPages();
services.AddControllersWithViews();

services.Configure<RazorViewEngineOptions>(


    // {0} actions
    // {1} controller
    // {2} areas
    options =>
    {
        options.ViewLocationFormats.Add("/MyViews/{1}/{0}" + RazorViewEngine.ViewExtension);
    }
);

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

app.AddStatusCodePage();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.MapControllerRoute(
    name: "firstroute",
    pattern: "{controller=home}/{action=index}/{id?}"
);

app.Run();
