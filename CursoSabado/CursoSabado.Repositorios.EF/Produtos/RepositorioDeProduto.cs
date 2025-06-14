using CursoSabado.Dominio.Produtos;
using CursoSabado.Repositorios.EF.Framework;
using CursoSabado.Repositorios.Produtos;

namespace CursoSabado.Repositorios.EF.Produtos
{
    public class RepositorioDeProduto : RepositorioBasicoComDescricao<Produto>, IRepositorioDeProduto
    {
        public RepositorioDeProduto(CursoSabadoContexto contexto) : base(contexto)
        {

        }
    }
}