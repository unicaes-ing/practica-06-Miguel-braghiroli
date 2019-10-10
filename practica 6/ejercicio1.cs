using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_6
{
    class ejercicio1
    {
        static void tabla(int num)
        {
            for (int i = 1; i <= 10; i++)
            {
                int total = 0;
                total = num * i;
                Console.WriteLine("{0} * {1} = {2}", num, i, total);
            }
        }
        static void Tabla(int numero, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            tabla(numero);
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Escriba un numero para la tabla de multiplicar");
            n = Convert.ToInt32(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("Números mayor que 0");
            }
            else
            {
                tabla(n);
                Console.WriteLine("========================");
                Tabla(n, ConsoleColor.Green);
            }
            Console.ReadKey();
        }
    }
}
