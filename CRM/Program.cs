using CRM.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//builder.Services.AddDbContext<DatabaseContext>(options =>
//{
//    options.UseSqlite(builder.Configuration.GetConnectionString("DatabaseContext"));
//});
// Services will be declared here
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
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Index}");

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

app.Run();
