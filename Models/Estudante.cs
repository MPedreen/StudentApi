public class Estudante
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public int NotaAtualId { get; set; }
    public virtual Nota Nota { get; set; }
}