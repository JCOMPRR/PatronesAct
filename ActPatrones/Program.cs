// Este es el Decorator

using ActPatrones;

List<string> productos = new List<string>() 
{ 
    "Latte Caramelo, ", "Muffin y ", "Leche Deslactosada"
};

IVenta venta = new Venta(productos);
Console.WriteLine(venta);

venta = new VentaDescuento(venta, 10);
Console.WriteLine(venta);