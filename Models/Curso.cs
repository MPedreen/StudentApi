namespace Models;

public class Curso
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public virtual IEnumerable<Estudante> Estudantes { get; set; }
}