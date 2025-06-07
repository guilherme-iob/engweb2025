using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CursoSabado.Dominio.Pessoas
{
    [Table("PESSOAS")]
    public class Pessoa
    {
        public int Id { get; set; }

        [Column("NOME")]
        public String NomeCompleto { get; set; }

        [Column("DATANASCIMENTO")]
        public DateTime? DataDeNascimento { get; set; }
    }
}