using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividad_1.presupuesto_de_la_langosta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables
            int CP, NUMP;
            double P;
            //Entrada
            Console.WriteLine("Ejemplo - Uso del if");
            Console.WriteLine("Programa para obtener un presupuesto");
            Console.WriteLine("ingresa el valor de numero de personas:");
            NUMP = int.Parse(Console.ReadLine());


            //Proceso entrada y salida 
            CP = 95;
            if (NUMP > 200 && NUMP <= 300)
            {
                CP = 85;
            }
            if (NUMP > 300)
            {
                CP = 75;
            }
            P = CP * NUMP;

            Console.WriteLine("El prosupuesto sera de:" + P);
            Console.ReadKey();

        }

    }
}
