namespace ActPatrones
{
    public class Venta : IVenta
    {
        private List<string> _productos;
        public Venta(List<string> productos)
        {
            _productos = productos;
        }
        public Venta():this(new List<string>()) 
        {

        }
        public decimal CalcularTotal()
        {
            decimal total = 96.13M;
            return total;
        }

        public List<string> ObtenerProductos()
        {
            return _productos;
        }

        public override string ToString() => 
            $"Total de {CalcularTotal():N2}";
    }
}
