using Strategy;

Boleto ticket = new Boleto(new BoletoDescuentoDistancia());
ticket.Origen = "Hermosillo";
ticket.Destino = "CDMX";
ticket.Horas = "2:30";
ticket.Precio = 6783m;

Console.WriteLine($"Su viaje a {ticket.Destino} con lugar de origen {ticket.Origen} tendra una duracion de {ticket.Horas} Horas");
Console.WriteLine($"El precio de su boleto con puntos aplicados es de {ticket.PrecioTotal} pesos");