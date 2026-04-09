using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE3_C
{
    internal class ejercicio1
    {
        static void Main(string[] args)
        {
            string name, career;
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.Write("Enter your career: ");
            career = Console.ReadLine();

            Console.WriteLine("\n---- Printed with + ----");
            Console.WriteLine(name + ",Welcome to the Algorithms course" +career);

            Console.WriteLine("\n ---- Printed with $ + ----");
            Console.WriteLine($"{name}, Welcome to the Algorithms course {career}");



            Console.ReadKey();



        }
    }
}
