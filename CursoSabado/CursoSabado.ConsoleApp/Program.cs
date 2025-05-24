using CursoSabado.Repositorios.EF;
using CursoSabado.Repositorios.EF.Pessoas;
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


        //Formato errado
        //var pessoas = contexto.Pessoas.Where(pessoa => pessoa.NomeCompleto.StartsWith("F")).ToList();

        RepositorioDePessoa repositorioDePessoa = new RepositorioDePessoa(contexto);
        var pessoas = repositorioDePessoa.ObterPorInicioDeNome("F");

        foreach (var p in pessoas)
        {
            Console.WriteLine(p.Id + " - " + p.NomeCompleto);
        }        
    }
}