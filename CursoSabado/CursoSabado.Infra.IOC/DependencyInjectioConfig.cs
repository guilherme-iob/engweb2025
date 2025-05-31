using CursoSabado.Repositorios.EF;
using CursoSabado.Servicos.Pessoas;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CursoSabado.Infra.IOC
{
    public static class DependencyInjectioConfig
    {
        public static IServiceCollection Registrar(this IServiceCollection service, IConfiguration config) 
        {
            service.AddSingleton<IConfiguration>(config);

            service.AddDbContext<CursoSabadoContexto>(options =>
                options.UseSqlServer(
                    config.GetConnectionString("DefaultConnection")
                )
            );

            //REPOSITÓRIOS
            //service.AddScoped<Repositorios.Pessoas.IRepositorioDePessoa, Repositorios.EF.Pessoas.RepositorioDePessoa>();            
            //service.AddScoped<Repositorios.Pessoas.IRepositorioDePessoa, Repositorios.ADONET.Pessoas.RepositorioDePessoaADONET>();
            //Foi usado AddSingleton porque os dados estão em memória na variável do próprio repositório.
            service.AddSingleton<Repositorios.Pessoas.IRepositorioDePessoa, Repositorios.FakeNews.Pessoas.RepositorioDePessoaFakeNews>();


            //SERVIÇOS
            service.AddScoped<IServicoDePessoa, ServicoDePessoa>();

            return service;
        }
    }
}