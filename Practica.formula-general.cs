using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula_general
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaracion de variables
            double a, b, c, x1 = 0, x2 = 0, A;
            Console.WriteLine("leer el valor a;");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("leer el valor b;");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("leer el valor c;");
            c = double.Parse(Console.ReadLine());
            //proceso de comparacion
            A = (Math.Pow(b, 2) - (4 * a * c));
            if
                (A >= 0)
            {
                x1 = (b + Math.Sqrt(A)) / (2 * a);
                x2 = (b - Math.Sqrt(A)) / (2 * a);

                Console.WriteLine("leer el valor de x1 es;" + x1);
                Console.WriteLine("leer el valor de x2 es;" + x2);
            }

             else
            {
                Console.WriteLine("los datos que ingreso son erroneos");
                }
            Console.ReadKey();
            }
        }

}
