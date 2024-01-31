var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddSession();

// builder.Services.AddAuthorization();

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Home/Error");
//}

// app.UseHttpsRedirection(); // be default http => https

app.UseStaticFiles();

app.UseRouting();

app.UseSession();

// app.UseAuthentication();

// app.UseAuthorization();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");



//app.MapControllerRoute(
//    name: "default2",
//    pattern: "{controller}/{action}/{catId}/{rating}");

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}"
    );
});

app.UseEndpoints((configure) =>
{
    app.MapControllerRoute(
    name: "default1",
    pattern: "{controller}/{action}/{id}/{catId}");

    app.MapControllerRoute(
    name: "default",
    pattern: "{controller=User}/{action=Index}/{id?}");
});


app.Run();
