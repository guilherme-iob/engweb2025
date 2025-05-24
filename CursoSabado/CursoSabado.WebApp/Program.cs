using CursoSabado.Repositorios.EF;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


//Conseguirmos refletir as atualizações das views em debug
builder.Services
    .AddRazorPages()
    .AddRazorRuntimeCompilation();

//Vinculando o Contexto do EF no DbContexto do core para usar como DI/IOC
builder.Services
    .AddDbContext<CursoSabadoContexto>(options =>
        options.UseSqlServer(
            builder.Configuration.GetConnectionString("DefaultConnection")
        )
    );

//VINCULOS ENTRE INTERFACES E CLASSES
//builder.Services.AddScoped<CursoSabado.Repositorios.Pessoas.IRepositorioDePessoa, CursoSabado.Repositorios.EF.Pessoas.RepositorioDePessoa>();
builder.Services.AddScoped<CursoSabado.Repositorios.Pessoas.IRepositorioDePessoa, CursoSabado.Repositorios.FakeNews.Pessoas.RepositorioDePessoaFakeNews>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
