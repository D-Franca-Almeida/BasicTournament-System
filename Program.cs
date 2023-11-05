using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BasicTournament_System.Data;
using Microsoft.Extensions.Options;
using System.Configuration;
var builder = WebApplication.CreateBuilder(args);
string connectionString = builder.Configuration.GetConnectionString("BasicTournament_SystemContext");
builder.Services.AddDbContext<BasicTournament_SystemContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));


//options.UseMySql(builder.Configuration.GetConnectionString(name: "BasicTournament_SystemContext"), builder =>
//                    builder.MigrationsAssembly("BasicTournament_SystemContext")));

// Add services to the container.
builder.Services.AddControllersWithViews();

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
    pattern: "{controller=Campeonatoes}/{action=Index}/{id?}"); //Chama a página "HOME" ou página de abertura

app.Run();
