﻿/*INTEGRANTES DEL GRUPO:
        Johan Sebastian Rios
        Luis Esteban Triana
        Juan Manuel Vanegas
        Andres Santiago Villamil 
  Jornada:
        Diurna
   Grupo:
        63102C / 239 - 2A*/ 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// ejercicico 2: Modifica el programa para que me indique por medio de un menú que si quiero ingresar o que los números
/// que se introducen en el array se generen de forma aleatoria (valores entre 100 y 999).



namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int ArraySize;
            bool Auth = false;
            Console.Write("¿Cuantos numeros van a ingresar?: ");
            ArraySize = int.Parse(System.Console.ReadLine());
            int[] Numbers = new int[ArraySize];
            selectOption(Numbers, Auth);
        }
        static void selectOption(int[] Numbers, bool Auth)
        {
            int option = 0;
            try
            {

                Console.WriteLine("¿Que quieres hacer?");
                option = int.Parse(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.Write("La option debe ser numerica");
                selectOption(Numbers, Auth);
            }
            switch (option)
            {
                case 1:
                    ArrayWithUserNumbers(Numbers);
                    Auth = true;
                    break;
                case 2:
                    ArrayWithSystemNumbers(Numbers);
                    Auth = true;
                    break;
                case 3:
                    if (Auth == false)
                    {
                        Console.WriteLine("No existen numeros disponibles para usar");
                        selectOption(Numbers, Auth);
                    }
                    else
                    {
                        showNumbers(Numbers);
                    }
                    break;
            }
        }
        static void ArrayWithUserNumbers(int[] Numbers)
        {
            bool Auth = true;
            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.Write("Escribe el numero {0}: ", (i + 1));
                Numbers[i] = int.Parse(System.Console.ReadLine());
                if (Numbers[i] < 100 || Numbers[i] > 999)
                {
                    Console.WriteLine("El numero debe ser mayor a 100 y menor a 999");
                    i--;
                }
            }
            selectOption(Numbers, Auth);

        }
        static void ArrayWithSystemNumbers(int[] Numbers)
        {
            bool Auth = true;
            Random RandomNumber = new Random();
            for (int i = 0; i < Numbers.Length; i++)
            {
                Numbers[i] = RandomNumber.Next(100, 999);
                Console.WriteLine(Numbers[i]);
            }
            selectOption(Numbers, Auth);
        }
        static void showNumbers(int[] Numbers)
        {
            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.Write("{0}: {1} \n", (i + 1), Numbers[i]);
            }
        }
    }
}