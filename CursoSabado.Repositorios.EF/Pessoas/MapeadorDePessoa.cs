using CursoSabado.Dominio.Pessoas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CursoSabado.Repositorios.EF.Pessoas
{
    public class MapeadorDePessoa : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.ToTable("PESSOAS");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("ID")
                .ValueGeneratedOnAdd();

            builder.Property(x => x.Nome).HasColumnName("NOME");

            builder.Property(x => x.DataDeNascimento).HasColumnName("DATANASCIMENTO");
        }
    }
}