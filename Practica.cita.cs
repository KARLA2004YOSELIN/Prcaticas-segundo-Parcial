using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_3.Citas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables
            int nc, a, b;
            //Entrada
            Console.WriteLine("Ejemplo - Uso del if");
            Console.WriteLine("Programa del consultorio del doctor lorezo T");
            Console.WriteLine("ingresa el numero de citas:");
            nc = int.Parse(Console.ReadLine());
            a = 200;
            b = 200;

            //Proceso entrada y salida
            if (nc <= 3)
            {
                a = (200 * nc);
                b = 200;
            }
            else if (nc >= 4 && nc <= 5)
            {
                a = (nc - 3) * 150 + 600;
                b = 150;
            }
            else if (nc >= 6 && nc <= 8)
            {
                a = (nc - 5) * 100 + 900;
                b = 100;
            }
            else
            {
                a = (nc - 8) * 50 + 1200;
                b = 50;

            }

            Console.WriteLine("El resultado por :" + nc + "citas");
            Console.WriteLine("El monto que pagara por el tratamiento es:" + a);
            Console.WriteLine("El costo de la cita es de :" + b);
            Console.ReadKey();
        }
    }
}
