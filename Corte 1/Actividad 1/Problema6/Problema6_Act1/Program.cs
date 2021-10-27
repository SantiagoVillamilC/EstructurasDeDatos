using System;

namespace Problema6_Act1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite el numero de segundos: ");
            var segundos = double.Parse(Console.ReadLine());
            double dia, horas, minutos;
            dia = (segundos / 3600) / 24;
            Console.WriteLine("-Son " + dia.ToString("N2") + " dia/s");
            horas = (segundos / 60) / 60;
            Console.WriteLine("-Son " + horas.ToString("N2") + " horas/s");
            minutos = (segundos / 60);
            Console.WriteLine("-Son " + minutos.ToString("N2") + " minuto/s");
        }
    }
}
