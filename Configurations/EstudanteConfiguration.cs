using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

public class EstudanteConfiguration : IEntityTypeConfiguration<Estudante>
{
    public void Configure(EntityTypeBuilder<Estudante> builder)
    {
        builder.ToTable("Estudantes");
        builder.HasKey(key => key.Id);
        builder.Property(prop => prop.Nome)
            .IsRequired()
            .HasMaxLength(50);

        builder.HasOne(ho => ho.Serie)
            .WithMany(wm => wm.Estudantes)
            .HasForeignKey(hf => hf.IdSerie);

        builder.HasOne(e => e.Endereco)
            .WithOne(wo => wo.Estudante)
            .HasForeignKey<EnderecoEstudante>(fk => fk.IdEstudante);

        builder.HasMany(e => e.Cursos)
            .WithMany(wm => wm.Estudantes)
            .UsingEntity<CursoEstudante>(
                x => x.HasOne(ho => ho.Curso)
                    .WithMany(),
                x => x.HasOne(ho => ho.Estudante)
                    .WithMany()
    );
    }
}
