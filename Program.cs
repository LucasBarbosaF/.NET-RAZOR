using Microsoft.EntityFrameworkCore;
using ProjetoMvc.Data;

var builder = WebApplication.CreateBuilder(args);

// 🔹 Adicione serviços ANTES de chamar builder.Build()
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllersWithViews();

var app = builder.Build(); // 🔹 `builder.Build()` só deve ser chamado aqui!

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
