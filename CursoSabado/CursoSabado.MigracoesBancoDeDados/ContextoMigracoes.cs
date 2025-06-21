using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CursoSabado.MigracoesBancoDeDados
{
    public class ContextoMigracoes : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);


            //TO DO: refatorar para usar do ENV ou appsettings
            optionsBuilder.UseSqlServer("Server=localhost;Database=cursoSabado;User Id=sa;Password=Senha#UmDoisTres;TrustServerCertificate=true");
        }
    }
}