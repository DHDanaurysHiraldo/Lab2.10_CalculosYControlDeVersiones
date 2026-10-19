
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;

//Desarrolla una aplicación que solicite:

//    Nombre del cliente
//    Saldo actual
//    Monto a depositar

//La aplicación deberá calcular:

//Y mostrar un resumen con el saldo anterior, depósito y nuevo saldo.
//Además, deberás registrar la evolución del proyecto utilizando Git.

decimal saldo = 56980;
string cliente = "Angel Guzman";


Console.Clear();
Console.WriteLine("===============================");
Console.WriteLine("===== SISTEMA DE DEPÓSITO =====");
Console.WriteLine("===============================");

Console.WriteLine("Usuario de Pruebas: Angel Guzman");
Console.WriteLine();

Console.Write("Ingrese el Nombre del Cliente: ");

string nombreCliente = Console.ReadLine();

if (nombreCliente != cliente)
    Console.WriteLine("Usuario no encontrado");
else
{
    Console.WriteLine($"Su saldo actual es de: RD${saldo}");
    Console.WriteLine();

    Console.Write("Ingrese el monto a Depositar: ");
    decimal montoDeposito = decimal.Parse(Console.ReadLine());

    Console.WriteLine($"Su saldo anterior era de: RD${saldo}");

    Console.WriteLine($"Su depósito es de: RD${montoDeposito}");

    //REALIZAR CALCULO...
    saldo = saldo + montoDeposito;

    Console.WriteLine($"Su saldo actual es de: RD${saldo}");


    
}





