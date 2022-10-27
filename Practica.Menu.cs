using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu
  {
        internal class Program
        {
            static void Main(string[] args)
            {
                //Declaracion de variables
                char letra;
                Console.WriteLine("Ejemplo menu - Uso del if");
                Console.WriteLine("menu");
                Console.WriteLine("Ingrese una letra ");

                //Entrada
                Console.WriteLine("ingrese una letra");
                letra = char.Parse(Console.ReadLine());

                //proceso
                if (letra == 'k')
                {
                    Console.WriteLine("karla yoselin");
                }
                if (letra == 'K')
                {
                    Console.WriteLine("KARLA YOSELIN");
                }
                if (letra == 'M')
                {
                    Console.WriteLine("MARTINEZ");
                }
                if (letra == 'm')
                {
                    Console.WriteLine("martinez");
                }
                if (letra == 'R')
                {
                    Console.WriteLine("RAMIREZ");
                }
                if (letra == 'r')
                {
                    Console.WriteLine("ramirez");
                }
                if (letra == 'm')
                {
                    Console.WriteLine("martinez");
                }
                Console.ReadKey();
            }
        }
    }
