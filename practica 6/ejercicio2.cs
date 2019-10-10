using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_6
{
    class ejercicio2
    {
        static void Dibujo1(int alto, int ancho)
        {
            for (int i = 1; i <= alto; i++)
            {
                for (int j = 1; j <= ancho; j++)
                {
                    if (i == 1 || i == alto || j == 1 || j == ancho)
                    {
                        Console.Write("*");
                    }
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        static void Dibujo2(int alto, int ancho, char caracter)
        {
            for (int i = 1; i <= alto; i++)
            {
                for (int j = 1; j <= ancho; j++)
                {
                    if (i == 1 || i == alto || j == 1 || j == ancho)
                    {
                        Console.Write(caracter);
                    }
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        static void Dibujo3(int alto, int ancho, char caracter, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            for (int i = 1; i <= alto; i++)
            {
                for (int j = 1; j <= ancho; j++)
                {
                    if (i == 1 || i == alto || j == 1 || j == ancho)
                    {
                        Console.Write(caracter);
                    }
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int dibujo;
            int ancho = 0, alto = 0;
            Console.WriteLine("Escriba el número para la figura:\n1. Cuadrado  2. Rectángulo");
            dibujo = Convert.ToInt32(Console.ReadLine());
            if (dibujo == 1)
            {
                do
                {
                    Console.WriteLine("Escriba el ancho del dibujo: ");
                    ancho = Convert.ToInt32(Console.ReadLine());
                } while (ancho <= 1);
                do
                {
                    Console.WriteLine("Escriba el alto del dibujo:");
                    alto = Convert.ToInt32(Console.ReadLine());
                } while (alto <= 1 && alto < ancho);
                Console.WriteLine();

                Dibujo1(alto, ancho);
                Console.WriteLine();
                Dibujo2(alto, ancho, '.');
                Console.WriteLine();
                Dibujo3(alto, ancho, '#', 10, 30);

                Console.ReadKey();
            }
            if (dibujo == 2)
            {
                do
                {
                    Console.WriteLine("Ingrese el ancho: ");
                    ancho = Convert.ToInt32(Console.ReadLine());
                } while (ancho <= 1);
                do
                {
                    Console.WriteLine("Ingrese el alto:");
                    alto = Convert.ToInt32(Console.ReadLine());

                } while (alto == ancho);
                Console.WriteLine();

                Dibujo1(alto, ancho);
                Console.WriteLine();
                Dibujo2(alto, ancho, '.');
                Console.WriteLine();
                Dibujo3(alto, ancho, '#', 5, 5);

                Console.ReadKey();
            }
        }
    }
}

