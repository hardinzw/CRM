using CRM.Models;
using Microsoft.EntityFrameworkCore;
using NuGet.Packaging.Core;
using SQLitePCL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddAuthentication()
    .AddJwtBearer();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

// Middleware
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Index method of home controller
// Default URL
#region Account Routing
app.MapControllerRoute(
    name: "Index",
    pattern: "{controller=Account}/{action=Index}");

//app.MapControllerRoute(
//    name: "Register",
//    pattern: "{controller=Account}/{action=Register}");
#endregion


#region Bug Routing
app.MapControllerRoute(
    name: "DisplayBugs",
    pattern: "{controller=Bug}/{action=Index}");

app.MapControllerRoute(
    name: "AddBug",
    pattern: "{controller=Bug}/{action=AddBug}");

app.MapControllerRoute(
    name: "EditBug",
    pattern: "{controller=Bug}/{action=EditBug}/{id?}");

app.MapControllerRoute(
    name: "DeleteBug",
    pattern: "{controller=Bug}/{action=DeleteBug}/{id?}");
#endregion

app.Run();
