using CursoSabado.Dominio.Pessoas;
using CursoSabado.Repositorios.Pessoas;
using CursoSabado.Servicos.Framework;

namespace CursoSabado.Servicos.Pessoas
{
    public class ServicoDePessoa : ServicoBasico<IRepositorioDePessoa, Pessoa>, IServicoDePessoa
    {
        public ServicoDePessoa(IRepositorioDePessoa repositorioPessoa) : base(repositorioPessoa)
        {
        }

        public IList<Pessoa> ObterPorInicioDeNome(String conteudo) 
        {
            return _repositorio.ObterPorInicioDeNome(conteudo);
        }

        public override Pessoa Salvar(Pessoa pessoa) 
        {
            if (pessoa.Nome.Split(' ').Count() <= 1)
            {
                throw new Exception("O nome deve possuir obrigatoriamente um sobrenome");
            }

            return base.Salvar(pessoa);
        }
    }
}