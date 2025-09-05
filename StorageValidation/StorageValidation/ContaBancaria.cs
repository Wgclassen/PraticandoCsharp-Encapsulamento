namespace StorageValidation;
using static SegurancaConta;

internal class ContaBancaria(string titular, double saldo)
{
    public string Titular { get; set; } = titular;
    public double Saldo { get; set; } = saldo;

    public void Sacar(double valor)
    {
        if (ValidarSaque(valor) && Saldo >= valor)
        {
            Saldo -= valor;
            Console.WriteLine("Saque realizado com sucesso.");
            Console.WriteLine($"Saldo atual: R$ {Saldo:F2}");
        } else
        {
            Console.WriteLine("Saque negado pela política de segurança.");
        }
    }

}
