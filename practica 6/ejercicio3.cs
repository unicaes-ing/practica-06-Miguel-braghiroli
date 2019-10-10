using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_6
{
    class ejercicio3
    {
        static double exp(int num, int EXP)
        {
            if (EXP == 0)
            {
                return 1;
            }
            else if (EXP < 0)
            {
                return exp(num, EXP + 1) / num;
            }
            else
            {
                return num * exp(num, EXP - 1);
            }
        }
        static void Main(string[] args)
        {
            int numero, exponente;
            Console.WriteLine("Ingrese el numero base");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el exponente");
            exponente = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} elevado a la {1} es: {2}", numero, exponente, exp(numero, exponente));
            Console.ReadKey();


        }
    }
}
