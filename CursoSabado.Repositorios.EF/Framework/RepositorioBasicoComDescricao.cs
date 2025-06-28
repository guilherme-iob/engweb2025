using CursoSabado.Dominio.Framework;

namespace CursoSabado.Repositorios.EF.Framework
{
    public abstract class RepositorioBasicoComDescricao<TTipo> : RepositorioBasico<TTipo>
        where TTipo : ObjetoComNome
    {
        protected RepositorioBasicoComDescricao(CursoSabadoContexto contexto) : base(contexto)
        {

        }

        public IList<TTipo> ObterPorInicioDeNome(String conteudo)
        {
            return Entidade.Where(x => x.Nome.StartsWith(conteudo)).ToList();
        }
    }
}