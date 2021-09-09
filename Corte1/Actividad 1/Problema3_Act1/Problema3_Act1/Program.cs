using System;

namespace Problema3_Act1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primera nota: ");
            var nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Segunda nota: ");
            var nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Tercera nota: ");
            var nota3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Cuarta nota: ");
            var nota4 = double.Parse(Console.ReadLine());
            double notamaxima = 0;
            double notaminima = 100;
            double promedio = 0;
            promedio = (nota1 + nota2 + nota3 + nota4) / 4;
            while (notamaxima == 0)
            {
                if (nota1 > notamaxima) { notamaxima = nota1; }
                if (nota2 > notamaxima) { notamaxima = nota2; }
                if (nota3 > notamaxima) { notamaxima = nota3; }
                if (nota4 > notamaxima) { notamaxima = nota4; }
            }
            while (notaminima == 100)
            {
                if (nota1 < notaminima) { notaminima = nota1; }
                if (nota2 < notaminima) { notaminima = nota2; }
                if (nota3 < notaminima) { notaminima = nota3; }
                if (nota4 < notaminima) { notaminima = nota4; }
            }
            Console.WriteLine("La nota maxima es: " + notamaxima);
            Console.WriteLine("La nota minima es: " + notaminima);
            Console.WriteLine("El promedio es: " + promedio);
        }
    }
}
