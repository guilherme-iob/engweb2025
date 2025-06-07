using CursoSabado.Dominio.Pessoas;
using CursoSabado.DTOs.Pessoas;

namespace CursoSabado.MapeadoresDTOs.Pessoas
{
    public interface IMapeadorDeDTODePessoa
    {
        Pessoa ParaEntidade(DTODePessoa dto);

        DTODePessoa ParaDTO(Pessoa modelo);

        IList<DTODePessoa> ParaDTO(IList<Pessoa> modelos);
    }
}