using CursoSabado.Repositorios.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World - Sistema versão Console");

        var configuration = new ConfigurationBuilder() 
            .SetBasePath(Directory.GetCurrentDirectory()) 
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

        var connectionString = configuration.GetConnectionString("DefaultConnection");

        var optionsBuilder = new DbContextOptionsBuilder<CursoSabadoContexto>();
        optionsBuilder.UseSqlServer(connectionString);

        var contexto = new CursoSabadoContexto(optionsBuilder.Options);

        var pessoas = contexto.Pessoas.ToList();

        foreach (var p in pessoas)
        {
            Console.WriteLine(p.Id + " - " + p.NomeCompleto);
        }

        
    }
}