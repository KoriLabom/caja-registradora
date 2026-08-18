// Etapa 4 - descuentos 

using System.ComponentModel.Design;
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
decimal descuento = 0;
const decimal descuentomayor = 0.1m;
const decimal descuentoefectivo = 0.1m;
const decimal descuentomenor = 0.05m;
const decimal recargocredito = 0.15m;
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
if (subtotal > 50000)
{
    total = subtotal - (subtotal * descuentomayor);
    descuento += descuentomayor;
}
else if (subtotal > 20000)
{
    total = subtotal - (subtotal * descuentomenor);
    descuento += descuentomenor;
}
else
{
    total = subtotal;
}
do
{
    Console.WriteLine();
    Console.WriteLine("Medio de pago:");
    Console.WriteLine("1 - Efectivo");
    Console.WriteLine("2 - Debito");
    Console.WriteLine("3 - Credito");
    opcion = Console.ReadLine() ?? "";
    switch (opcion)
    {
        case "1":
            total= total-(subtotal*descuentoefectivo);
            descuento += descuentoefectivo;
            break;
        case "2":
            break;
        case "3":
            total = total + (total * recargocredito);
            break;
        default:
            Console.WriteLine("Opción inválida.");
            break;
    }
}
while (opcion!="1" && opcion!="2" && opcion!="3");
Console.WriteLine();

Console.WriteLine($"Productos: {cantidadProductos}");
Console.WriteLine($"Subtotal: ${subtotal}");
Console.WriteLine($"Descuento aplicado: ${subtotal*descuento}");
Console.WriteLine($"Total: ${total}");

Console.ReadLine();
