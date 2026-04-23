using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE3_C
{
    internal class ejer4
    {
        static void Main(string[] args)
        {
            // Concatenacion de interpolacion poner en llaves la variable
            Console.Write("Ingrese un numero decimal: ");
            double num = double.Parse(Console.ReadLine());

            Console.WriteLine($"\nRaiz cuadrada:  {Math.Sqrt(num)}");
            Console.WriteLine($"Redondeado: {Math.Round(num, 0)}");
            Console.WriteLine($"Elevado al cubo:{Math.Pow(num, 3)}");
            Console.WriteLine($"Raiz cubica: {Math.Pow(num, 1 / 3d)}");
            //Agregamos subfijo "d" para obtener el resultado cuando son fracciones


        }

    }
}
