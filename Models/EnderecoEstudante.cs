namespace Models;

public class EnderecoEstudante
{
    public int Id { get; set; }
    public string Endereco { get; set; }
    public string Cidade { get; set; }
    public string Estado { get; set; }
    public string Pais { get; set; }
    public int IdEstudante { get; set; }
    public virtual Estudante Estudante { get; set; }
}