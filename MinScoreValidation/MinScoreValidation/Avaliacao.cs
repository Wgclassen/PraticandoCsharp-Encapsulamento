namespace MinScoreValidation
{
    internal class Avaliacao(string aluno)
    {
        public string Aluno { get; } = aluno;
        public double Nota { get; private set; }

        public void AtribuirNota(double nota)
        {
            if (nota < 0 || nota > 10)
            {
                Console.WriteLine("Erro: A nota deve estar entre 0 e 10.");
            } else
            {
                Nota = nota;
                Console.WriteLine($"Aluno: {Aluno}\nNota atribuída: {Nota}");
            }
        }
    }
}