using CursoSabado.Repositorios.EF.Pessoas;
using Microsoft.EntityFrameworkCore;

namespace CursoSabado.Repositorios.EF
{
    public class CursoSabadoContexto : DbContext
    {
        public CursoSabadoContexto(DbContextOptions<CursoSabadoContexto> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MapeadorDePessoa());
        }
    }
}