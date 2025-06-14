using CursoSabado.Dominio.Framework;
using Microsoft.EntityFrameworkCore;

namespace CursoSabado.Repositorios.EF.Framework
{
    public abstract class RepositorioBasico<TTipo>
        where TTipo : ObjetoComId
    {
        private readonly CursoSabadoContexto _contexto;

        protected DbSet<TTipo> Entidade;

        public RepositorioBasico(CursoSabadoContexto contexto)
        {
            _contexto = contexto;
            Entidade = _contexto.Set<TTipo>();
        }

        public IList<TTipo> ObterTodos()
        {
            return Entidade.ToList();
        }

        public TTipo? Obter(int id)
        {
            return Entidade.Where(x => x.Id == id).FirstOrDefault();
        }

        public TTipo Adicionar(TTipo pessoa)
        {
            _contexto.Add(pessoa);
            _contexto.SaveChanges();
            return pessoa;
        }
    }
}