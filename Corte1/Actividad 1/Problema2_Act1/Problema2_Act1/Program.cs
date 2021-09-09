using System;

namespace Problema2_Act1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Precio primera pelicula:");
            int pelicula1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Precio segunda pelicula:");
            int pelicula2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Precio tercera pelicula:");
            int pelicula3 = Convert.ToInt32(Console.ReadLine());
            int preciofinal = 0;
            if (pelicula1 > pelicula2 && pelicula1 > pelicula3)
            {
                preciofinal = pelicula2 + pelicula3;
                Console.WriteLine("La pelicula 1 es la más cara, por lo que el precio final es: " + preciofinal);
            }
            if (pelicula2 > pelicula1 && pelicula2 > pelicula3)
            {
                preciofinal = pelicula1 + pelicula3;
                Console.WriteLine("La pelicula 2 es la más cara, por lo que el precio final es: " + preciofinal);
            }
            if (pelicula3 > pelicula1 && pelicula3 > pelicula2)
            {
                preciofinal = pelicula2 + pelicula1;
                Console.WriteLine("La pelicula 3 es la más cara, por lo que el precio final es: " + preciofinal);
            }
        }
    }
}
