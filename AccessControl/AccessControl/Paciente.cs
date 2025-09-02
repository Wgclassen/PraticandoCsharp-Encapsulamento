namespace AccessControl;

internal class Paciente(string nome, int idade)
{
    public string Nome { get; set; } = nome;
    public int Idade { get; set; } = idade;
}
