using CursoSabado.Dominio.Pessoas;
using CursoSabado.Repositorios.Pessoas;

namespace CursoSabado.Repositorios.FakeNews.Pessoas
{
    public class RepositorioDePessoaFakeNews : IRepositorioDePessoa
    {
        private IList<Pessoa> _pessoasFake;

        public RepositorioDePessoaFakeNews()
        {
            _pessoasFake = Seed();
        }

        public Pessoa? Obter(int id)
        {
            return _pessoasFake.FirstOrDefault(x => x.Id == id);
        }

        private IList<Pessoa> Seed() 
        {
            var pessoas = new List<Pessoa>();

            for (int i = 1; i <= 10; i++)
            {
                pessoas.Add(new Pessoa() { Id = i, NomeCompleto = $"Pessoa Fake News {i}" });
            }

            return pessoas;
        }

        public IList<Pessoa> ObterPorInicioDeNome(string conteudo)
        {
            return _pessoasFake.Where(x => x.NomeCompleto.StartsWith(conteudo)).ToList();
        }

        public IList<Pessoa> ObterTodos()
        {
            return _pessoasFake;
        }

        public Pessoa Adicionar(Pessoa pessoa)
        {
            pessoa.Id = DateTime.Now.Millisecond;

            _pessoasFake.Add(pessoa);

            return pessoa;
        }
    }
}