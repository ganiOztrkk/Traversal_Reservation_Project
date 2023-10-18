using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc.Razor;
using TraversalProject.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews()
    .AddRazorOptions(options =>
    {
        options.ViewLocationFormats.Add("/Pages/{0}.cshtml");
        options.ViewLocationFormats.Add("/Pages/{1}/{0}" + RazorViewEngine.ViewExtension);
    });
//builder.Services.Configure<RazorViewEngineOptions>(opt =>
   // opt.ViewLocationFormats.Add("/Pages/{1}/{0}" + RazorViewEngine.ViewExtension));

builder.Services.AddInjections(); // ioc extensions

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Destination}/{action=Index}/{id?}");

app.Run();