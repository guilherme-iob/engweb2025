using CursoSabado.Dominio.Pessoas;
using CursoSabado.Dominio.Produtos;
using CursoSabado.Infra.IOC;
using CursoSabado.Repositorios.ADONET.Pessoas;
using CursoSabado.Repositorios.Pessoas;
using CursoSabado.Repositorios.Produtos;
using CursoSabado.Servicos.Pessoas;
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

        var provider = StartupApp();

        IServicoDePessoa servicoDePessoa = provider.GetRequiredService<IServicoDePessoa>();
        IRepositorioDeProduto repositorioDeProduto = provider.GetRequiredService<IRepositorioDeProduto>();

        do
        {
            try
            {
                Console.WriteLine("\n-----------------------------------------");
                Console.WriteLine("1 - Cadastrar Pessoa");
                Console.WriteLine("2 - Listas Pessoas");
                Console.WriteLine("3 - Cadastrar Produto");
                Console.WriteLine("4 - Listas Produtos");
                Console.WriteLine("5 - Buscar Pessoas");
                Console.WriteLine("99 - Sair");
                Console.WriteLine("-----------------------------------------");
                Console.Write("Informe a opção: ");

                int opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Console.Write("Informar o nome completo da pessoa: ");
                    String nome = Console.ReadLine();

                    var novaPessoa = new Pessoa();
                    novaPessoa.Nome = nome;

                    servicoDePessoa.Salvar(novaPessoa);
                }
                else if (opcao == 2)
                {
                    Console.Clear();
                    var pessoas = servicoDePessoa.ObterTodos();
                    foreach (var p in pessoas)
                    {
                        Console.WriteLine(p.Id + " - " + p.Nome);
                    }
                }
                else if (opcao == 3)
                {
                    Console.Write("Informar o nome do produto: ");
                    String nome = Console.ReadLine();

                    var produto = new Produto();
                    produto.Nome = nome;

                    repositorioDeProduto.Adicionar(produto);
                }
                else if (opcao == 4)
                {
                    Console.Clear();
                    var produtos = repositorioDeProduto.ObterTodos();
                    foreach (var p in produtos)
                    {
                        Console.WriteLine(p.Id + " - " + p.Nome);
                    }
                }
                else if (opcao == 5)
                {
                    Console.Clear();
                    Console.WriteLine("Informe o valor de busca: ");
                    String busca = Console.ReadLine();

                    var pessoas = servicoDePessoa.ObterPorInicioDeNome(busca);
                    foreach (var p in pessoas)
                    {
                        Console.WriteLine(p.ToString());
                    }
                }
                else if (opcao == 99)
                {
                    break;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("================================================================");
                Console.WriteLine($"Erro: {ex.Message}");
                Console.WriteLine("================================================================");
            }
        }
        while (true);
    }
}