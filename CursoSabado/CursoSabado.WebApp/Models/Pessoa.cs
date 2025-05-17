using System.ComponentModel.DataAnnotations.Schema;

namespace CursoSabado.WebApp.Models
{
    [Table("PESSOAS")]
    public class Pessoa
    {
        public int Id { get; set; }

        [Column("NOME")]
        public String NomeCompleto { get; set; }
    }
}