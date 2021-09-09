using System;

namespace Problema7_Act1
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;
            Console.WriteLine("Digite valor de ventas para A:");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite valor de ventas para B:");
            B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite valor de ventas para C:");
            C = Convert.ToInt32(Console.ReadLine());
            if (A > B && A > C)
            {
                Console.WriteLine("Las ventas del producto A son las más elevadas. ");
            }
            if (A > 200 && B > 200 && C > 200)
            {
                Console.WriteLine("Ningún producto tiene unas ventas inferiores a 200. ");
            }
            if (A > 400 || B > 400 || C > 400)
            {
                Console.WriteLine("Algún producto tiene unas ventas superiores a 400. ");
            }
            if ((A + B + C) / 3 > 500)
            {
                Console.WriteLine("La media de ventas es superior a 500. ");
            }
            if (A > B || C > B)
            {
                Console.WriteLine("El producto B no es el más vendido.");
            }
            if ((A + B + C) >= 500 && (A + B + C) <= 1000)
            {
                Console.WriteLine("El total de ventas esta entre 500 y 1000.");
            }
        }
    }
}
