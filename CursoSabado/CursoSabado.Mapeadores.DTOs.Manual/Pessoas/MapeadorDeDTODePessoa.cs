using CursoSabado.Dominio.Pessoas;
using CursoSabado.DTOs.Pessoas;
using CursoSabado.MapeadoresDTOs.Pessoas;

namespace CursoSabado.Mapeadores.DTOs.Manual.Pessoas
{
    public class MapeadorDeDTODePessoa : IMapeadorDeDTODePessoa
    {
        public DTODePessoa ParaDTO(Pessoa modelo)
        {
            var dto = new DTODePessoa();

            dto.Id = modelo.Id;
            dto.NomeCompleto = modelo.Nome;            
            dto.DataNascimento = modelo.DataDeNascimento;

            if (dto.DataNascimento.HasValue) 
            {
                dto.DescricaoIdade = $"{DateTime.Now.Year - dto.DataNascimento.Value.Year} anos";
            }
                        
            return dto;
        }

        public IList<DTODePessoa> ParaDTO(IList<Pessoa> pessoas) 
        {
            return pessoas.Select(x => ParaDTO(x)).ToList();
        }

        public Pessoa ParaEntidade(DTODePessoa dto)
        {
            var modelo = new Pessoa();
            modelo.Id = dto.Id;
            modelo.Nome = dto.NomeCompleto;
            modelo.DataDeNascimento = dto.DataNascimento;
            return modelo;
        }
    }
}