using CursoSabado.Dominio.Framework;

namespace CursoSabado.Servicos.Framework
{
    public interface IServicoBasico<TEntidade>
        where TEntidade : ObjetoComId
    {
        IList<TEntidade> ObterTodos();

        TEntidade? Obter(int id);

        TEntidade Salvar(TEntidade pessoa);
    }
}