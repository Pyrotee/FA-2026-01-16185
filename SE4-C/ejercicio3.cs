using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE4_C
{
    internal class ejercicio3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---SISTEMA DE CONVERSION DE MONEDA ---");
            Console.WriteLine("Ingrese el monto en soles:");
            double soles = double.Parse(Console.ReadLine());
            Console.WriteLine("***** MENU DE OPCIONES *****");
            Console.WriteLine("* 1. Dolares               *");
            Console.WriteLine("* 2. Euros                 *");
            Console.WriteLine("**************************\n");
            Console.WriteLine("Ingrese una opcion:");
            int opc = int.Parse(Console.ReadLine());
             switch (opc)
             {
                 case 1:
                     double dolares = soles / 3.75;
                     Console.WriteLine($"El monto en dolares es: {dolares}");
                     break;
                 case 2:
                     double euros = soles / 4.20;
                     Console.WriteLine($"El monto en euros es: {euros}");
                     break;
                 default:
                     Console.WriteLine("Opcion no valida.");
                     break;
             }
             Console.ReadKey();
        }
    }
}
