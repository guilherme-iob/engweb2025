using CursoSabado.Dominio.Pessoas;
using CursoSabado.Repositorios.EF.Framework;
using CursoSabado.Repositorios.Pessoas;

namespace CursoSabado.Repositorios.EF.Pessoas
{
    public class RepositorioDePessoa : RepositorioBasicoComDescricao<Pessoa>, IRepositorioDePessoa
    {
        public RepositorioDePessoa(CursoSabadoContexto contexto) : base(contexto)
        {
        
        }
    }
}