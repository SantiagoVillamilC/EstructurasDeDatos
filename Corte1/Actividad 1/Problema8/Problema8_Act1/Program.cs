using System;

namespace Problema8_Act1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor ingrese un caracter:");
            string c = Console.ReadLine();

            if (c == "a" || c == "A" || c == "e" || c == "E" || c == "i" || c == "I" || c == "O" || c == "o" || c == "u" || c == "U")
            {
                Console.WriteLine("El caracter ingresado es una vocal\n");
            }
            char ch = char.Parse(c);
            if (Char.IsLower(ch))
            {
                Console.WriteLine("El caracter ingresado es una letra minusculan\n");
            }
            if (Char.IsSymbol(ch))
            {
                Console.WriteLine("El caracter ingresado es un simbolo");
            }

            Console.ReadKey();
        }
    }
}
