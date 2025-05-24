using CursoSabado.Dominio.Pessoas;

namespace CursoSabado.Repositorios.Pessoas
{
    public interface IRepositorioDePessoa
    {
        IList<Pessoa> OterTodos();

        Pessoa? Obter(int id);
        
        IList<Pessoa> ObterPorInicioDeNome(String conteudo);
    }
}