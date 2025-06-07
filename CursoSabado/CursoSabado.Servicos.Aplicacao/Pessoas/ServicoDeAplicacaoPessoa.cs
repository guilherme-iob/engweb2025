using CursoSabado.DTOs.Pessoas;
using CursoSabado.MapeadoresDTOs.Pessoas;
using CursoSabado.Servicos.Pessoas;

namespace CursoSabado.Servicos.Aplicacao.Pessoas
{
    public class ServicoDeAplicacaoPessoa : IServicoDeAplicacaoPessoa
    {
        private readonly IServicoDePessoa _servicoPessoa;
        private readonly IMapeadorDeDTODePessoa _mapeador;

        public ServicoDeAplicacaoPessoa(IServicoDePessoa servPessoa, IMapeadorDeDTODePessoa mapDto)
        {
            _servicoPessoa = servPessoa;
            _mapeador = mapDto;
        }

        public IList<DTODePessoa> ObterTodos() 
        {
            return _mapeador.ParaDTO(_servicoPessoa.ObterTodos());
        }

        public DTODePessoa? Obter(int id) 
        {
            return _mapeador.ParaDTO(_servicoPessoa.Obter(id));
        }

        public IList<DTODePessoa> ObterPorInicioDeNome(String conteudo) 
        {
            return _mapeador.ParaDTO(_servicoPessoa.ObterPorInicioDeNome(conteudo));
        }

        public DTODePessoa Salvar(DTODePessoa pessoa) 
        {
            throw new NotImplementedException();
        }
    }
}