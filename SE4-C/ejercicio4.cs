using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE4_C
{
    internal class ejercicio4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---SISTEMA DE CALCULO DE AREAS---\n");

            Console.WriteLine("Menu de opciones:");
            Console.WriteLine("1. Cuadrado");
            Console.WriteLine("2. Rectangulo");
            Console.WriteLine("3. Triangulo");
            Console.WriteLine("4. Circulo\n");

            Console.Write("Ingrese una opcion: ");
            int opc = int.Parse(Console.ReadLine());

            double area;

            switch (opc)
            {
                case 1:
                    Console.Write("\n Ingrese lado: ");
                    int lc = int.Parse(Console.ReadLine());
                    area = lc * lc;
                    Console.WriteLine($"El area del cuadrado es: {area}");
                    break;
                case 2:
                    Console.Write("\n Ingrese base: ");
                    int br = int.Parse(Console.ReadLine());
                    Console.Write("\n Ingrese altura: ");
                    int ar = int.Parse(Console.ReadLine());
                    area = br * ar;
                    Console.WriteLine($"El area del rectangulo es: {area}");
                    break;
                case 3:
                    Console.Write("\n Ingrese base: ");
                    int bt = int.Parse(Console.ReadLine());
                    Console.Write("\n Ingrese altura: ");
                    int at = int.Parse(Console.ReadLine());
                    area = (bt * at) / 2;
                    Console.WriteLine($"El area del triangulo es: {area}");
                    break;
                case 4:
                    Console.Write("\n Ingrese radio: ");
                    int rc = int.Parse(Console.ReadLine());
                    area = Math.PI * Math.Pow(rc,2);
                    Console.WriteLine($"\nEl area del circulo es: {area}");
                    break;
                default: Console.Write("\nOpcion incorrecta!"); break;

            }

        }
    }
}
