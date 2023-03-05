using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace Configurations;

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

        builder.HasOne(e => e.Serie)
            .WithMany(s => s.Estudantes)
            .HasForeignKey(e => e.IdSerie);
    }
}
