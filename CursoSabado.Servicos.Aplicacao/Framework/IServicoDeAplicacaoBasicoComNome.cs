
namespace CursoSabado.Servicos.Aplicacao.Framework
{
    public interface IServicoDeAplicacaoBasicoComNome<TDTO> : IServicoDeAplicacaoBasico<TDTO>
        where TDTO : class
    {
        IList<TDTO> ObterPorInicioDeNome(String conteudo);
    }
}