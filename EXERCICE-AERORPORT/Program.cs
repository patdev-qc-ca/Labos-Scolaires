var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationContext>();
/*// Services personnalisés
builder.Services.AddScoped<NumberRandomizer, NumberRandomizer>();

*/
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "aeroport",
    pattern: "aeroport/{action}/{id?}");

app.MapControllerRoute(
    name: "client",
    pattern: "client/{action}/{id?}");
app.MapControllerRoute(
    name: "passager",
    pattern: "passager/creer");

app.Run();
