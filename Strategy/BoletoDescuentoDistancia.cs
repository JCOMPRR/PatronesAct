using Strategy;

public class BoletoDescuentoDistancia : ICalcularPrecio
{
    public decimal CalcularPuntos(decimal precio)
    {
        return precio * 0.5m;
    }
}