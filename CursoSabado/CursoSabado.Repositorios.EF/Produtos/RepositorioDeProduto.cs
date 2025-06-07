using CursoSabado.Dominio.Produtos;
using CursoSabado.Repositorios.Produtos;
using Microsoft.EntityFrameworkCore;

namespace CursoSabado.Repositorios.EF.Produtos
{
    public class RepositorioDeProduto : IRepositorioDeProduto
    {
        private readonly CursoSabadoContexto _contexto;

        private DbSet<Produto> produtos;

        public RepositorioDeProduto(CursoSabadoContexto contexto)
        {
            _contexto = contexto;
            produtos = _contexto.Set<Produto>();
        }

        public IList<Produto> ObterTodos()
        {
            return produtos.ToList();
        }

        public Produto? Obter(int id)
        {
            return produtos.Where(x => x.Id == id).FirstOrDefault();
        }

        public IList<Produto> ObterPorInicioDeNome(String conteudo)
        {
            return produtos.Where(x => x.Descricao.StartsWith(conteudo)).ToList();
        }

        public Produto Adicionar(Produto pessoa)
        {
            _contexto.Add(pessoa);
            _contexto.SaveChanges();
            return pessoa;
        }
    }
}