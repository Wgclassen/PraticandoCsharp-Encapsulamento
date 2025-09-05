namespace ContactList;

internal class Contato(string nome, string telefone)
{
    public string Nome { get; } = nome;
    public string Telefone { get; } = telefone;
}
