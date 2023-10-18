namespace ActPatrones
{
    public class VentaDescuento : VentaDecorador
    {
        private decimal _porcentajeDescuento;
        public VentaDescuento(IVenta venta, decimal porcentajeDescuento) 
            : base(venta)
        {
            _porcentajeDescuento = porcentajeDescuento;
        }

        public override decimal CalcularTotal()
        {
            decimal totalBase = base.CalcularTotal();
            decimal descuento = totalBase * (_porcentajeDescuento / 100);
            return totalBase - descuento;
        }
        public override string ToString()
        {
            return $"Total {CalcularTotal():N2} con descuento de {CalcularTotal():N2}%";
        }
    }    
}
