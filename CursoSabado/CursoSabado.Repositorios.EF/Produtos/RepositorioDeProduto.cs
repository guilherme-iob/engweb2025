using CursoSabado.Dominio.Produtos;
using CursoSabado.Repositorios.EF.Framework;
using CursoSabado.Repositorios.Produtos;

namespace CursoSabado.Repositorios.EF.Produtos
{
    public class RepositorioDeProduto : RepositorioBasico<Produto>, IRepositorioDeProduto
    {
        public RepositorioDeProduto(CursoSabadoContexto contexto) : base(contexto)
        {

        }

        public IList<Produto> ObterPorInicioDeNome(String conteudo)
        {
            return Entidade.Where(x => x.Descricao.StartsWith(conteudo)).ToList();
        }
    }
}