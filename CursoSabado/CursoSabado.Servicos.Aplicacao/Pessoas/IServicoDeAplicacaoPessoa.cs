using CursoSabado.DTOs.Pessoas;

namespace CursoSabado.Servicos.Aplicacao.Pessoas
{
    public interface IServicoDeAplicacaoPessoa
    {
        IList<DTODePessoa> ObterTodos();
        DTODePessoa? Obter(int id);
        IList<DTODePessoa> ObterPorInicioDeNome(String conteudo);
        DTODePessoa Salvar(DTODePessoa pessoa);
    }
}