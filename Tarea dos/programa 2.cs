using System;

namespace programa 2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                System.Console.WriteLine("Introduce un número de dos cifras");
                byte n1 = System.Convert.ToByte(System.Console.ReadLine());
                System.Console.WriteLine("Introduce un número de dos cifras");
                byte n2 = System.Convert.ToByte(System.Console.ReadLine());

                ushort resultado = System.Convert.ToByte(n1 * n2);

                System.Console.WriteLine("El resultado es: " + resultado);
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine("error");
            }
        }
    }
}