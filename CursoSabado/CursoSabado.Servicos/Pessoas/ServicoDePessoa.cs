using CursoSabado.Dominio.Pessoas;
using CursoSabado.Repositorios.Pessoas;

namespace CursoSabado.Servicos.Pessoas
{
    public class ServicoDePessoa : IServicoDePessoa
    {
        private readonly IRepositorioDePessoa _repositorioDePessoa;

        public ServicoDePessoa(IRepositorioDePessoa repositorioPessoa)
        {
            _repositorioDePessoa = repositorioPessoa;
        }

        public IList<Pessoa> ObterTodos() 
        {
            return _repositorioDePessoa.ObterTodos();
        }

        public Pessoa? Obter(int id) 
        {
            return _repositorioDePessoa.Obter(id);
        }

        public IList<Pessoa> ObterPorInicioDeNome(String conteudo) 
        {
            return _repositorioDePessoa.ObterPorInicioDeNome(conteudo);
        }

        public Pessoa Salvar(Pessoa pessoa) 
        {
            if (pessoa.NomeCompleto.Split(' ').Count() <= 1)
            {
                throw new Exception("O nome deve possuir obrigatoriamente um sobrenome");
            }

            if (pessoa.Id > 0)
            {
                throw new NotImplementedException("");
            }
            else 
            {
                return _repositorioDePessoa.Adicionar(pessoa);
            }
        }
    }
}