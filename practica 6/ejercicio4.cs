using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_6
{
    class ejercicio4
    {
        static void Main(string[] args)
        {
            int num = 0, bas = 2, residuo = 0;
            string digito, conversion = "";
            Console.WriteLine("Escriba un número decimal:");
            num = Convert.ToInt32(Console.ReadLine());
            while (num > 0)
            {
                residuo = num % bas;
                num = num / bas;
                digito = "" + residuo;
                conversion = digito + conversion;
            }
            Console.WriteLine();
            Console.WriteLine("La conversion es: {0}", conversion);
            Console.ReadKey();
        }
    }
}
