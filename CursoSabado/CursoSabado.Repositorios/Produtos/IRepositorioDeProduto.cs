using CursoSabado.Dominio.Produtos;

namespace CursoSabado.Repositorios.Produtos
{
    public interface IRepositorioDeProduto
    {
        IList<Produto> ObterTodos();

        Produto? Obter(int id);

        IList<Produto> ObterPorInicioDeNome(String conteudo);

        Produto Adicionar(Produto pessoa);
    }
}