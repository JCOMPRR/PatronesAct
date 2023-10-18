namespace Strategy
{
    public class Boleto
    {
        private readonly ICalcularPrecio _calcularPrecio;

        public Boleto(ICalcularPrecio calcularPrecio)
        {
            _calcularPrecio = calcularPrecio;
        }

        public string Origen { get; set; }
        public string Destino { get; set; }
        public string Horas { get; set; }
        public decimal Precio { get; set; }
        public decimal PrecioTotal { get => Precio - CalcularPrecio();}

        
        public decimal CalcularPrecio()
        {
            return _calcularPrecio.CalcularPuntos(Precio);
        }
    
    }
}
