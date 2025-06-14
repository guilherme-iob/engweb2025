using CursoSabado.Dominio.Produtos;
using CursoSabado.Repositorios.Framework;

namespace CursoSabado.Repositorios.Produtos
{
    public interface IRepositorioDeProduto : IRepositorioBasico<Produto>
    {
        IList<Produto> ObterPorInicioDeNome(String conteudo);
    }
}