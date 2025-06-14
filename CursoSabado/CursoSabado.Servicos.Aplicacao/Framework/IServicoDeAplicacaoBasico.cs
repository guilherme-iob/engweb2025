namespace CursoSabado.Servicos.Aplicacao.Framework
{
    public interface IServicoDeAplicacaoBasico<TDTO>
        where TDTO : class
    {
        IList<TDTO> ObterTodos();
        TDTO? Obter(int id);
        TDTO Salvar(TDTO pessoa);
    }
}