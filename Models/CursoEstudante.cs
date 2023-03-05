namespace Models;

public class CursoEstudante
{
    public int CursoId { get; set; }
    public virtual Curso Curso { get; set; }
    public int EstudanteId { get; set; }
    public virtual Estudante Estudante { get; set; }
}