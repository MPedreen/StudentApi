namespace Models;

public class Serie
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public virtual IEnumerable<Estudante> Estudantes  { get; set; }
}