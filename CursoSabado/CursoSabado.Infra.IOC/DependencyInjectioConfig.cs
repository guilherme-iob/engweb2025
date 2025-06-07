using CursoSabado.Mapeadores.DTOs.Manual.Pessoas;
using CursoSabado.MapeadoresDTOs.Pessoas;
using CursoSabado.Repositorios.EF;
using CursoSabado.Servicos.Aplicacao.Pessoas;
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
            service.AddScoped<Repositorios.Pessoas.IRepositorioDePessoa, Repositorios.EF.Pessoas.RepositorioDePessoa>();
            //service.AddScoped<Repositorios.Pessoas.IRepositorioDePessoa, Repositorios.ADONET.Pessoas.RepositorioDePessoaADONET>();
            //Foi usado AddSingleton porque os dados estão em memória na variável do próprio repositório.
            //service.AddSingleton<Repositorios.Pessoas.IRepositorioDePessoa, Repositorios.FakeNews.Pessoas.RepositorioDePessoaFakeNews>();


            //MAPEADORES
            service.AddScoped<IMapeadorDeDTODePessoa, MapeadorDeDTODePessoa>();

            //SERVIÇOS
            service.AddScoped<IServicoDePessoa, ServicoDePessoa>();

            //SERVIÇOS DE APLICAÇÃO
            service.AddScoped<IServicoDeAplicacaoPessoa, ServicoDeAplicacaoPessoa>();

            return service;
        }
    }
}