using Microsoft.EntityFrameworkCore;
using vcart.Data;
using vcart.Repositories.Implementations;
using vcart.Repositories.Interfaces;
using vcart.services.Implementations;
using vcart.services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();

// dependency register
// builder.Services.AddScoped<>
// builder.Services.AddTransient<>
// builder.Services.AddSingleton<>


builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("B20CRUDDB"));
});

var app = builder.Build();


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Categories}/{action=Index}/{id?}");

app.Run();
