// Etapa 3 - Carga de varios productos

const string NombreComercio = "KIOSCO EL RECREO";

Console.WriteLine($"=== {NombreComercio} ===");

Console.Write("Nombre del cajero: ");
string? cajero = Console.ReadLine();

Console.WriteLine($"Bienvenida, {cajero}. Caja abierta.");

decimal total = 0;
int cantidadProductos = 0;
string opcion;

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

            total += precio;
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
Console.WriteLine($"Productos: {cantidadProductos}");
Console.WriteLine($"Total: ${total}");

Console.ReadLine();
