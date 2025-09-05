namespace ContactList;

internal class Agenda(string proprietario)
{
    public string Proprietario { get; } = proprietario;
    private readonly List<Contato> Contatos = [];
    public int QuantidadeContatos => Contatos.Count;
    public bool AdicionarContato(Contato contato)
    {
        if (Contatos.Any(c => c.Nome.Equals(contato.Nome)))
        {
            Console.WriteLine("Contato com esse nome já está na agenda.");
            return false;
        } else
        {
            Contatos.Add(contato);
            return true;
        }
    }

    public void ListarContatos()
    {
        Console.WriteLine($"Agenda de: {Proprietario}");
        Console.WriteLine("Contatos:");
        foreach (var contato in Contatos)
        {
            Console.WriteLine($" - {contato.Nome} | {contato.Telefone}");
        }
        Console.WriteLine("Total de contatos: " + QuantidadeContatos);
    }

}
