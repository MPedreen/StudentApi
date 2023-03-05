using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace Configurations;

public class CursosEstudantesConfiguration : IEntityTypeConfiguration<CursoEstudante>
{
    public void Configure(EntityTypeBuilder<CursoEstudante> builder)
    {
        builder.HasKey(key => new { key.EstudanteId, key.CursoId });

        builder.HasOne(ho => ho.Estudante)
            .WithMany(wm => wm.CursosEstudantes)
            .HasForeignKey(fk => fk.EstudanteId);

        builder.HasOne(ho => ho.Curso)
            .WithMany(wm => wm.CursosEstudantes)
            .HasForeignKey(fk => fk.CursoId);
    }
}
