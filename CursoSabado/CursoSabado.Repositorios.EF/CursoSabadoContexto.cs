using CursoSabado.Dominio.Pessoas;
using Microsoft.EntityFrameworkCore;

namespace CursoSabado.Repositorios.EF
{
    public class CursoSabadoContexto : DbContext
    {
        public CursoSabadoContexto(DbContextOptions<CursoSabadoContexto> options) : base(options)
        {

        }

        public DbSet<Pessoa> Pessoas { get; set; }
    }
}