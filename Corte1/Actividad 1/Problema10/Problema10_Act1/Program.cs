using System;

namespace Problema10_Act1
{
    class Program
    {
        static void Main(string[] args)
        {
            string contraseña = "iloveyou123", pru; //Contraseña establecida
            do
            {
                Console.WriteLine("Bienvenido");
                Console.WriteLine("Ingrese la contraseña:");
                pru = Console.ReadLine();
                if (pru != contraseña)
                {
                    Console.WriteLine("Contraseña incorrecta \n");
                }
            }
            while (pru != contraseña);
            Console.WriteLine("Contraseña correcta \n");
            Console.WriteLine("Muchas gracias\n");
        }
    }
}
