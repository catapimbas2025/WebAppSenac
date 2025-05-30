using Microsoft.EntityFrameworkCore;
using WebAppSenac.Models;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//CONFIGURAR A CONEXÃO DO BANCO DE DADOS
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

//REGISTRAR O CONTEXTO DO BANCO DE DADOS
IServiceCollection serviceCollection = builder.Services.AddDbContext<ContextoEscola>(options => options.UseSqlServer(connectionString));


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

app.Run();
