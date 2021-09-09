using System;

namespace Problema1_Act1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor introduzca un numero para saber su valor absoluto:");
            int x = Convert.ToInt32(Console.ReadLine());
            int absoluto;
            if (x < 0)
            {
                absoluto = -x;
            }
            else
            {
                absoluto = x;
            }
            Console.WriteLine("El valor absoluto es: " + absoluto);
        }
    }
}
