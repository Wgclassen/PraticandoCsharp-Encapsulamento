namespace StudentApproval;

internal class Estudante(string nome)
{
    public string Nome { get; set; } = nome;
    public double Nota1 { get; set; }
    public double Nota2 { get; set; }
    public double Media => (Nota1 + Nota2) / 2;
    public string Situacao => Media >= 6 ? "Aprovado" : "Reprovado";
}
