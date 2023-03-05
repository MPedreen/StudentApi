using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace Configurations;

public class EnderecoConfiguration : IEntityTypeConfiguration<EnderecoEstudante>
{
    public void Configure(EntityTypeBuilder<EnderecoEstudante> builder)
    {
        builder.ToTable("Enderecos");
        builder.HasKey(key => key.Id);
        builder.Property(prop => prop.Rua).HasMaxLength(100);
        builder.Property(prop => prop.Cidade).HasMaxLength(50);
        builder.Property(prop => prop.Estado).HasMaxLength(50);
        builder.Property(prop => prop.Pais).HasMaxLength(30);

        builder.HasOne(ho => ho.Estudante)
            .WithOne(wo => wo.Endereco)
            .HasForeignKey<EnderecoEstudante>(fk => fk.IdEstudante);
    }
}