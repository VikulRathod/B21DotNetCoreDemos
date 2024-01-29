var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// builder.Services.AddAuthorization();

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Home/Error");
//}

app.UseStaticFiles();

app.UseRouting();

// app.UseAuthentication();

// app.UseAuthorization();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");



//app.MapControllerRoute(
//    name: "default2",
//    pattern: "{controller}/{action}/{catId}/{rating}");



app.UseEndpoints((configure) =>
{
    app.MapControllerRoute(
    name: "default1",
    pattern: "{controller}/{action}/{id}/{catId}");

    app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Category}/{action=Index}/{id?}");
});

app.Run();
