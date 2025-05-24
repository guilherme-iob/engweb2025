using CursoSabado.Infra.IOC;
using CursoSabado.Repositorios.Pessoas;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Sistema - Versão Console");

        var configuration = new ConfigurationBuilder() 
            .SetBasePath(Directory.GetCurrentDirectory()) 
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

        var services = new ServiceCollection();
        services.Registrar(configuration);

        var provider = services.BuildServiceProvider();

        IRepositorioDePessoa repositorioDePessoa = provider.GetRequiredService<IRepositorioDePessoa>();

        var pessoas = repositorioDePessoa.OterTodos();

        foreach (var p in pessoas)
        {
            Console.WriteLine(p.Id + " - " + p.NomeCompleto);
        }        
    }
}