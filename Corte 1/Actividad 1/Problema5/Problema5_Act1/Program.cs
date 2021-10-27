using System;

namespace Problema5_Act1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite un numero: ");
            var raiz = double.Parse(Console.ReadLine());
            double resultado;
            if (raiz > 0)
            {
                resultado = Math.Sqrt(raiz);
                Console.WriteLine(resultado);
            }
            else
            {
                Console.WriteLine("El numero debe ser positivo");
            }
        }
    }
}
