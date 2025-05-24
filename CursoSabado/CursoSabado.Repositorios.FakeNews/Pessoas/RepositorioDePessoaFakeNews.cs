using CursoSabado.Dominio.Pessoas;
using CursoSabado.Repositorios.Pessoas;

namespace CursoSabado.Repositorios.FakeNews.Pessoas
{
    public class RepositorioDePessoaFakeNews : IRepositorioDePessoa
    {
        public Pessoa? Obter(int id)
        {
            return new Pessoa() { Id = id, NomeCompleto = "Pessoa Fake Criado em Tempo de Execução" };
        }

        private IList<Pessoa> CriarListas() 
        {
            var pessoas = new List<Pessoa>();

            for (int i = 1; i <= 10; i++)
            {
                pessoas.Add(new Pessoa() { Id = i, NomeCompleto = $"Nome Completo da Pessoa {i}" });
            }

            return pessoas;
        }

        public IList<Pessoa> ObterPorInicioDeNome(string conteudo)
        {
            return CriarListas().Where(x => x.NomeCompleto.StartsWith(conteudo)).ToList();
        }

        public IList<Pessoa> OterTodos()
        {
            return CriarListas();
        }
    }
}