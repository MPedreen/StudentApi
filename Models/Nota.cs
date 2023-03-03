public class Nota
{
    public int NotaId { get; set; }
    public string NotaNome { get; set; }
    public virtual IEnumerable<Estudante> Estudantes  { get; set; }
}