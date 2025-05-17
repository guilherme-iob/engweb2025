using Microsoft.EntityFrameworkCore;

namespace CursoSabado.WebApp.Models
{
    public class CursoSabadoContexto : DbContext
    {
        public CursoSabadoContexto(DbContextOptions<CursoSabadoContexto> options) : base(options)
        {

        }

        public DbSet<Pessoa> Pessoas { get; set; }
    }
}