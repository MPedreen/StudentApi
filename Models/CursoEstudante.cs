namespace Models;

public class CursoEstudante
{
    public int CursoId { get; set; }
    public Curso Curso { get; set; }
    public int EstudanteId { get; set; }
    public Estudante Estudante { get; set; }
}