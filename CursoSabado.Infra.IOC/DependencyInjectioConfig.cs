using CursoSabado.Mapeadores.DTOs.Manual.Pessoas;
using CursoSabado.MapeadoresDTOs.Pessoas;
using CursoSabado.Repositorios.EF;
using CursoSabado.Repositorios.EF.Pessoas;
using CursoSabado.Repositorios.EF.Produtos;
using CursoSabado.Repositorios.Pessoas;
using CursoSabado.Repositorios.Produtos;
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

            #region REPOSITÓRIOS

            #region Exemplo com Outras Tecnologias e formas para o acesso ao banco de dados

            //service.AddScoped<Repositorios.Pessoas.IRepositorioDePessoa, Repositorios.ADONET.Pessoas.RepositorioDePessoaADONET>();
            //Foi usado AddSingleton porque os dados estão em memória na variável do próprio repositório.
            //service.AddSingleton<Repositorios.Pessoas.IRepositorioDePessoa, Repositorios.FakeNews.Pessoas.RepositorioDePessoaFakeNews>();

            #endregion

            service.AddScoped<IRepositorioDePessoa, RepositorioDePessoa>();
            service.AddScoped<IRepositorioDeProduto, RepositorioDeProduto>();

            #endregion

            #region MAPEADORES

            service.AddScoped<IMapeadorDeDTODePessoa, MapeadorDeDTODePessoa>();

            #endregion

            #region SERVIÇOS

            service.AddScoped<IServicoDePessoa, ServicoDePessoa>();

            #endregion

            #region SERVIÇOS DE APLICAÇÃO

            service.AddScoped<IServicoDeAplicacaoPessoa, ServicoDeAplicacaoPessoa>();

            #endregion

            return service;
        }
    }
}