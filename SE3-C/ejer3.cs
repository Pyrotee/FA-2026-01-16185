using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE3_C
{
    class ejer3
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter a number 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nSuma: " + (num1 + num2));
            Console.WriteLine("\nResta: " + (num1 - num2));
            Console.WriteLine("\nMultiplicacion: " + (num1 * num2));
            Console.WriteLine("\nDivision: " + (num1 / num2));

        }

    }
}
