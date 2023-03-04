public class Estudante
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public int IdSerie { get; set; }
    public virtual Serie Serie { get; set; }
}