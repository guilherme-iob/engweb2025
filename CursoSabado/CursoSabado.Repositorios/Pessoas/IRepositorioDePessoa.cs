using CursoSabado.Dominio.Pessoas;
using CursoSabado.Repositorios.Framework;

namespace CursoSabado.Repositorios.Pessoas
{
    public interface IRepositorioDePessoa : IRepositorioBasico<Pessoa>
    {
        IList<Pessoa> ObterPorInicioDeNome(String conteudo);
    }
}