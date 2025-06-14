using CursoSabado.Dominio.Pessoas;
using CursoSabado.Repositorios.EF.Framework;
using CursoSabado.Repositorios.Pessoas;

namespace CursoSabado.Repositorios.EF.Pessoas
{
    public class RepositorioDePessoa : RepositorioBasico<Pessoa>, IRepositorioDePessoa
    {
        public RepositorioDePessoa(CursoSabadoContexto contexto) : base(contexto)
        {
        
        }
        
        public IList<Pessoa> ObterPorInicioDeNome(String conteudo) 
        {
            return Entidade.Where(x => x.NomeCompleto.StartsWith(conteudo)).ToList();
        }
    }
}