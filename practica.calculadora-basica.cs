using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraBasicaCASE
{
    internal class Program
    {
        static void Main(string[] args)
        { //Declarar variables
            char opcion, operador = ' ';
            //Declarando e inicializando variables
            //Se asigna el valor de 0 a las variables
            double num1 = 0, num2 = 0, resultado = 0;
            Console.WriteLine("Calculadora Basica");
            Console.WriteLine("Selecciona una opcion: ");
            Console.WriteLine("S - Suma");
            Console.WriteLine("R - Resta");
            Console.WriteLine("D - Division");
            Console.WriteLine("M - Multiplicacion");
            Console.WriteLine("Selecciona una opcion: ");
            opcion = char.Parse(Console.ReadLine());
            Console.ReadKey();
            if (opcion == 'S' || opcion == 'R' || opcion == 'M' || opcion == 'D')
            {
                Console.WriteLine("Ingresa el primer numero: ");
                num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa el segundo numero: ");
                num2 = double.Parse(Console.ReadLine());
                //realizar la operacion segun la opcion
                switch (opcion)
                {
                    case 'S':
                        resultado = num1 + num2;
                        operador = '+';
                        break;
                    case 'R':
                        resultado = num1 - num2;
                        operador = '-';
                        break;
                    case 'D':
                        resultado = num1 /  num2;
                        operador = '/';
                        break;
                    case 'M':
                        resultado = num1 * num2;
                        operador = '*';
                        break;
                }
                //Salida
                Console.WriteLine(num1 + " " + operador + " " + num2 + " " + " = " + resultado);

            }
            else
            {
                Console.WriteLine("Verificar la opcion ");
            }
            Console.ReadKey();
        }
    }
}
