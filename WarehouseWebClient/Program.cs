using WarehouseWebClient.Common.Extensions.Configurations;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddApplicationServices();

var app = builder.Build();
app.UseStaticFiles();

app.MapControllerRoute(
    name: "default", 
    pattern: "{controller=Home}/{action=Index}");

app.Run();