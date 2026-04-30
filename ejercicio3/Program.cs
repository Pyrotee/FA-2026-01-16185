using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    internal class Program
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
                case 0:
                    double dolares;
                    dolares = soles / 3.75;

                    Console.WriteLine("Dolares: "+Math.Round(dolares));
                    break;
                case 1:
                    double euro;
                    euro = soles / 3.75;
                    Console.WriteLine("\nDolares: " + Math.Round(euro,1));
                    break;

                default: Console.WriteLine("Opcion incorrecta."); break;

            }




        }
    }
}
