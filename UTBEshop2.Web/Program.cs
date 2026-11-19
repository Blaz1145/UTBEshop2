using Microsoft.EntityFrameworkCore;
using UTBEshop2.Infrastructure.Database;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

string connectionString = builder.Configuration.GetConnectionString("MySQL"); //precita z appsettings.json
ServerVersion serverVersion = ServerVersion.AutoDetect(connectionString); //zisti verziu MySQL pre EF Core

builder.Services.AddDbContext<EshopDbContext>(options => options.UseMySql(connectionString,serverVersion)); //zaregistruje DbContext do DI (dependency injection)

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();