namespace StorageValidation;

internal class SegurancaConta
{
    public static bool ValidarSaque(double valor)
    {
        if (valor <= 1000 && valor > 0)
        {
            return true;
        } else
        {
            return false;
        }
    }
}
