namespace EnrollmentControl;

internal class Curso(string nome, int vagasTotais)
{
    public string Nome { get; set; } = nome;
    public int VagasTotais { get; } = vagasTotais;
    public int VagasDisponiveis => VagasTotais - Matriculas.Count();
    public List<Estudante> Matriculas { get; } = [];
    public bool Matricular(Estudante estudante)
    {
        if (VagasDisponiveis > 0)
        {
            Matriculas.Add(estudante);
            Console.WriteLine("Estudante matriculado com sucesso.");
            return true;
        }
        else
        {
            Console.WriteLine("Erro: Não há vagas disponíveis para este curso.");
            return false;
        }
    }

    public void ListarMatriculados()
    {
        Console.WriteLine($"\nEstudantes matriculados em {Nome}");
        foreach (var aluno in Matriculas)
        {
            Console.WriteLine(" - " + aluno.Nome);
        }
        Console.WriteLine("Vagas disponíveis: " + VagasDisponiveis);
    }
}
