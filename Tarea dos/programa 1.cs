using System;

namespace Programa_1
{
    class Program
    {
        static void Main(string[] args)
        {

            byte años;

            Console.WriteLine("Introducir su edad: ");
            años = byte.Parse(Console.ReadLine());
            Console.WriteLine("No aparentas tener " + años + " años");
            Console.ReadKey();
        }
    }
}


