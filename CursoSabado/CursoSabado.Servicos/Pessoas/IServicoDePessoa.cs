using CursoSabado.Dominio.Pessoas;

namespace CursoSabado.Servicos.Pessoas
{
    public interface IServicoDePessoa
    {
        IList<Pessoa> ObterTodos();
        
        Pessoa? Obter(int id);
        
        IList<Pessoa> ObterPorInicioDeNome(String conteudo);
        
        Pessoa Salvar(Pessoa pessoa);
    }
}