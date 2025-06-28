using CursoSabado.Dominio.Framework;

namespace CursoSabado.Repositorios.Framework
{
    public interface IRepositorioBasico<TEntidade>
        where TEntidade : ObjetoComId
    {
        IList<TEntidade> ObterTodos();

        TEntidade? Obter(int id);

        TEntidade Adicionar(TEntidade pessoa);
    }
}