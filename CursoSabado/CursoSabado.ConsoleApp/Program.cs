using CursoSabado.Dominio.Pessoas;
using CursoSabado.Infra.IOC;
using CursoSabado.Repositorios.ADONET.Pessoas;
using CursoSabado.Repositorios.Pessoas;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

internal class Program
{
    private static ServiceProvider StartupApp() 
    {
        var configuration = new ConfigurationBuilder()
                  .SetBasePath(Directory.GetCurrentDirectory())
                  .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                  .Build();

        var services = new ServiceCollection();
        services.Registrar(configuration);

        return services.BuildServiceProvider();
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("Sistema - Versão Console");

		try
		{
            var provider = StartupApp();

            IRepositorioDePessoa repositorioDePessoa = provider.GetRequiredService<IRepositorioDePessoa>();

            do
            {
                Console.WriteLine("\n-----------------------------------------");
                Console.WriteLine("1 - Cadastrar Pessoa");
                Console.WriteLine("2 - Listas Pessoas");
                Console.WriteLine("99 - Sair");
                Console.WriteLine("-----------------------------------------");
                Console.Write("Informe a opção: ");

                int opcao = int.Parse(Console.ReadLine());

                if (opcao == 1) 
                {
                    Console.Write("Informar o nome completo da pessoa: ");
                    String nome = Console.ReadLine();

                    var novaPessoa = new Pessoa();
                    novaPessoa.NomeCompleto = nome;

                    repositorioDePessoa.Adicionar(novaPessoa);
                }
                else if (opcao == 2)
                {
                    Console.Clear();
                    var pessoas = repositorioDePessoa.ObterTodos();
                    foreach (var p in pessoas)
                    {
                        Console.WriteLine(p.Id + " - " + p.NomeCompleto);
                    }
                }
                else if (opcao == 99) 
                {
                    break;
                }
            }
            while (true);
        }
		catch (Exception ex)
		{
            Console.WriteLine("================================================================");
            Console.WriteLine($"Problema: {ex}");
            Console.WriteLine("================================================================");
        }     
    }
}