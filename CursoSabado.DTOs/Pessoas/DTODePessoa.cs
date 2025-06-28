using CursoSabado.Dominio.Framework;

namespace CursoSabado.DTOs.Pessoas
{
    public class DTODePessoa : ObjetoComNome
    {
        public DateTime? DataNascimento { get; set; }

        public String DescricaoIdade { get; set; }
    }
}