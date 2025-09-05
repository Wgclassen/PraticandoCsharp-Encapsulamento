namespace TaskControl;

internal class Projeto(string nome)
{
    public string Nome { get; set; } = nome;
    private List<string> Tarefas { get; set; } = new List<string>();
    public void AdicionarTarefa(string tarefa)
    {
        Tarefas.Add(tarefa);
    }

    public void ExibirTarefas()
    {
        Console.WriteLine($"Projeto: {Nome}");
        Console.WriteLine("Tarefas:");
        foreach (var tarefa in Tarefas)
        {
            Console.WriteLine($" - {tarefa}");
        }
        Console.WriteLine($"Total: {Tarefas.Count} tarefas");
    }
}
