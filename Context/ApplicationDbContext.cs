using Configurations;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Context;

public class ApplicationDbContext : DbContext
{
    public DbSet<Curso> Cursos { get; set; }
    public DbSet<Estudante> Estudantes { get; set; }
    public DbSet<Serie> Series { get; set; }
    public DbSet<EnderecoEstudante> EnderecosEstudante { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CursoConfiguration());
    }
}