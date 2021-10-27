using System;

namespace Problema4_Act1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite un numero entero: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            while (numero != 1)
            {
                if ((numero % 2) == 0) //Numero par
                {
                    numero = numero / 2;
                    Console.WriteLine(numero);
                    continue;
                }
                if ((numero % 2) != 0)
                {
                    numero = (numero * 3) + 1;
                    Console.WriteLine(numero);
                    continue;
                }
            }
        }
    }
}
