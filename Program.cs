
decimal saldo = 56980.00m;
string cliente = "Angel Guzman";
string nombreCliente = string.Empty;

/*Utilicé while para mantener un bucle del mismo código para evitar lineas de codigo redundantes
 * así podemos utilizar las palabras reservadas "continue" y "break" */

while (true) 
{
    Console.WriteLine("===============================");
    Console.WriteLine("===== SISTEMA DE DEPÓSITO =====");
    Console.WriteLine("===============================");

    Console.WriteLine("Usuario de Pruebas: Angel Guzman");
    Console.WriteLine();

    Console.Write("Ingrese el Nombre del Cliente: ");
    nombreCliente = Console.ReadLine();

    if (nombreCliente == cliente)
    {
        Console.WriteLine($"Su saldo actual es de: RD${saldo}");
        Console.WriteLine();

        Console.Write("Ingrese el monto a Depositar: "); //Con el TryParse evitamos que el usuario introduzca una respuesta inválida...
        if (!decimal.TryParse(Console.ReadLine(), out decimal montoDeposito) || montoDeposito <= 0)
        {
            Console.WriteLine("Monto inválido. Presione una tecla para reintentar...");
            Console.ReadKey();
            Console.Clear();
            continue;
        }

        Console.Clear();
        Console.WriteLine("===============================");
        Console.WriteLine("===== SISTEMA DE DEPÓSITO =====");
        Console.WriteLine("===============================");

        Console.WriteLine($"Su saldo anterior era de: RD${saldo}");
        Console.WriteLine($"Su depósito es de: RD${montoDeposito}");

        //REALIZAR CALCULO...
        saldo = saldo + montoDeposito;

        Console.WriteLine();
        Console.WriteLine("==================================");

        Console.WriteLine($"Su saldo actual es de: RD${saldo}");
        break; //break: Para romper el bucle y terminar el programa.
    }
    else
    {
        Console.WriteLine("Usuario no encontrado");
        Console.WriteLine("Presione ENTER u otra tecla para volver a intentar");

        Console.ReadKey();
        Console.Clear(); //Esta linea es para limpiar la consola y que parezca que realmente se reinició la interfaz...
        continue; //continue: Para volver al inicio del bucle.
    }
}
