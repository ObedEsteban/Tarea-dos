using System;
using System.Collections.Generic;
using System.Text;

namespace programa 3
{
    class Ejercicios
    {
       
        public static void Ejercicio4()
        {
            try
            {
                System.Console.WriteLine("introduce un numero entero");
                long n1 = System.Convert.ToInt64(System.Console.ReadLine());
                System.Console.WriteLine("introduce un numero entero");
                long n2 = System.Convert.ToInt64(System.Console.ReadLine());
                long suma = System.Convert.ToInt64(n1 + n2);
                long resta = System.Convert.ToInt64(n1 - n2);
                long multiplicacion = System.Convert.ToInt64(n1 * n2);

                System.Console.WriteLine(" La suma es: " + suma + ",  La resta es: " + resta + ", La multiplicacion es: " + multiplicacion);
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine("error");
            }
        }