namespace SalaryAdjustment;

internal class Funcionario(string nome, double salario)
{
    public string Nome { get; set; } = nome;
    public double Salario { get; private set; } = salario;
    public void ReajustarSalario(double novoValor)
    {
        if (novoValor > Salario)
        {
            Salario = novoValor;
        } else
        {
            Console.WriteLine("Erro: O novo salário deve ser maior que o atual.");
        }

    }
}
