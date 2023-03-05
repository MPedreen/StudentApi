namespace Models;

public class Estudante
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public int IdSerie { get; set; }
    public virtual Serie Serie { get; set; }
    public virtual EnderecoEstudante Endereco { get; set; }
    public virtual IEnumerable<Curso> Cursos { get; set; }
    public virtual IEnumerable<CursoEstudante> CursosEstudantes { get; set; }
}