using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Database.Configurations;

public class CursoConfiguration : IEntityTypeConfiguration<Curso>
{
    public void Configure(EntityTypeBuilder<Curso> curso)
    {
        curso.ToTable("Cursos");
        curso.HasKey(key => key.Id);
        curso.Property(prop => prop.Nome).IsRequired().HasMaxLength(50);
        curso.Property(prop => prop.Descricao).HasMaxLength(100);

        curso.HasMany(hm => hm.Estudantes)
            .WithMany(wm => wm.Cursos)
            .UsingEntity(ue => ue.ToTable("CursosEstudantes"));
    }
}