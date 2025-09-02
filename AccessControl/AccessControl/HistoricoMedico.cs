namespace AccessControl;

internal class HistoricoMedico(string codigoProntuario)
{
    public string CodigoProntuario { get; set; } = codigoProntuario;

    public void ExibirCodigo()
    {
        Console.WriteLine($"Código do prontuário: {CodigoProntuario}");
    }
}
