public class Nota
{
    public int Id { get; set; }
    public int Valor { get; set; }
    public int EstudanteId { get; set; }
    public Estudante Estudante { get; set; }
}