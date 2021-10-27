using System;

namespace Problema9_Act1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite el numero de años de su perro: ");
            var años = double.Parse(Console.ReadLine());
            double años_huma = 0;
            if (años > 2)
            {
                años_huma = 21;
                años = años - 2;
                while (años != 0)
                {
                    años = años - 1;
                    años_huma = años_huma + 4;
                    continue;
                }
                Console.WriteLine("-Son " + años_huma.ToString("N2") + " años de humano");
            }
            if (años <= 2)
            {
                if (años == 1)
                {
                    Console.WriteLine("-Son 10.5 años de humano");

                }
                if (años == 2)
                {
                    Console.WriteLine("-Son 21 años de humano");
                }
            }
        }
    }
}
