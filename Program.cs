// Etapa 4 - descuentos 

using System.Text;

const string NombreComercio = "KIOSCO EL RECREO";

Console.WriteLine($"=== {NombreComercio} ===");

Console.Write("Nombre del cajero: ");
string? cajero = Console.ReadLine();

Console.WriteLine($"Bienvenida, {cajero}. Caja abierta.");

decimal total = 0;
decimal subtotal = 0;
int cantidadProductos = 0;
string opcion;
const decimal descuentodiez = 0.1m;
const decimal descuentocinco = 0.05m;

do
{
    Console.WriteLine();
    Console.WriteLine("¿Qué desea hacer?");
    Console.WriteLine("1 - Cargar un producto");
    Console.WriteLine("2 - Cerrar la venta");
    opcion = Console.ReadLine() ?? "";

    switch (opcion)
    {
        case "1":
            Console.Write("Producto: ");
            string? producto = Console.ReadLine();

            Console.Write("Precio: ");
            decimal precio = decimal.Parse(Console.ReadLine() ?? "");

            subtotal += precio;
            cantidadProductos++;

            Console.WriteLine($"Cargado: {producto} - ${precio}");
            break;

        case "2":
            break;

        default:
            Console.WriteLine("Opción inválida.");
            break;
    }
} while (opcion != "2");

Console.WriteLine();
if (subtotal > 50000)
{
    total = subtotal*(1-descuentodiez);
}
else if (subtotal > 20000)
{
    total = subtotal*(1-descuentocinco);
}
else
{     
    total = subtotal;
}
Console.WriteLine($"Productos: {cantidadProductos}");
Console.WriteLine($"Subtotal: ${subtotal}");
Console.WriteLine($"Descuento aplicado: ${subtotal-total}");
Console.WriteLine($"Total: ${total}");

Console.ReadLine();
