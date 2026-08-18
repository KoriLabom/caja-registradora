// Etapa 2 - Carga de un producto

const string NombreComercio = "KIOSCO EL RECREO";

Console.WriteLine($"=== {NombreComercio} ===");

Console.Write("Nombre del cajero: ");
string? cajero = Console.ReadLine();

Console.WriteLine($"Bienvenida, {cajero}. Caja abierta.");

Console.Write("Producto: ");
string? producto = Console.ReadLine();

Console.Write("Precio: ");
string entradaPrecio = Console.ReadLine() ?? "";
decimal precio = decimal.Parse(entradaPrecio);

Console.WriteLine($"Cargado: {producto} - ${precio}");

Console.ReadLine();
