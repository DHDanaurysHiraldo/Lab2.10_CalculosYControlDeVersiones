
using static System.Runtime.InteropServices.JavaScript.JSType;

//Desarrolla una aplicación que solicite:

//    Nombre del cliente
//    Saldo actual
//    Monto a depositar

//La aplicación deberá calcular:

//Y mostrar un resumen con el saldo anterior, depósito y nuevo saldo.
//Además, deberás registrar la evolución del proyecto utilizando Git.

ushort saldo = 56980;
string cliente = "Angel Guzman";


Console.Clear();
Console.WriteLine("===============================");
Console.WriteLine("===== SISTEMA DE DEPÓSITO =====");
Console.WriteLine("===============================");


Console.WriteLine("Ingrese el Nombre del Cliente: ");
Console.WriteLine("Como prueba es 'Angel Guzmán'");
Console.WriteLine();
string nombreCliente = Console.ReadLine();

if (nombreCliente != cliente)
    Console.WriteLine("Usuario no encontrado");
else
{
    Console.WriteLine($"Su saldo actual es de: {saldo}");
    Console.WriteLine();

    Console.WriteLine("Ingrese el monto a Depositar: ");
    ushort montoDeposito = ushort.Parse(Console.ReadLine());

    
    //quedamos en realizar el calculo...
}





