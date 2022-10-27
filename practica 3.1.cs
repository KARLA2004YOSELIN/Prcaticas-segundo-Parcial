using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practi0422
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables
            int a, b;
            //Entrada
            Console.WriteLine("Ejemplo 3.1 - Uso del if");
            Console.WriteLine("Programa para obtener el mayor  de 2 numeros ");
            Console.WriteLine("Escribe el primer numero:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el primer numero :");
            b = int.Parse(Console.ReadLine());

            //Proceso de comparacion y salida
            if (a > b)
                Console.WriteLine("El mayor valor es: " + a);
            if (a < b)
                Console.WriteLine("El mayor valor es: " + b);
            if (a == b)
            Console.WriteLine(" los valores son iguales ");

            Console.ReadKey();

        }
    }
}
