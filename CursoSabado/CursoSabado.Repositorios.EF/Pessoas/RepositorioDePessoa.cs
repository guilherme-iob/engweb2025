using CursoSabado.Dominio.Pessoas;
using CursoSabado.Repositorios.Pessoas;
using Microsoft.EntityFrameworkCore;

namespace CursoSabado.Repositorios.EF.Pessoas
{
    public class RepositorioDePessoa : IRepositorioDePessoa
    {
        private readonly CursoSabadoContexto _contexto;

        private DbSet<Pessoa> pessoas;

        public RepositorioDePessoa(CursoSabadoContexto contexto)
        {
            _contexto = contexto;
            pessoas = _contexto.Set<Pessoa>();
        }
        
        public IList<Pessoa> ObterTodos() 
        {
            return pessoas.ToList();
        }

        public Pessoa? Obter(int id) 
        {
            return pessoas.Where(x => x.Id == id).FirstOrDefault();
        }

        public IList<Pessoa> ObterPorInicioDeNome(String conteudo) 
        {
            return pessoas.Where(x => x.NomeCompleto.StartsWith(conteudo)).ToList();
        }

        public Pessoa Adicionar(Pessoa pessoa)
        {
            _contexto.Add(pessoa);            
            _contexto.SaveChanges();
            return pessoa;
        }
    }
}