/*INTEGRANTES DEL GRUPO:
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

/// Ejercicico 3: Define un array de números enteros de 3 filas por 6 columnas con nombre num y asigna los valores cuando se inicie el programa.
/// Muestra el contenido de todos los elementos del arraydispuestos en forma de tabla.



namespace Ejercicio_3
{ 
    class Ejercicio_3
    {
        int[,] Matriz = new int[3, 6];
        int LONGITUD_FILA = 3;
        int LONGITUD_COLUMNA = 6;

        public void CargarMatriz()
        {

            for (int f = 0; f < LONGITUD_FILA; f++)
            {
                for (int c = 0; c < LONGITUD_COLUMNA; c++)
                {
                    Console.Write($"Ingrese primer numero {f + 1}, {c + 1} de la matriz: ");
                    Matriz[f, c] = int.Parse(System.Console.ReadLine());
                }
            }
        }

        public void ImprimirMatriz()
        {
            Console.WriteLine("\nLa matriz es: ");

            for (int f = 0; f < LONGITUD_FILA; f++)
            {
                for (int c = 0; c < LONGITUD_COLUMNA; c++)
                {
                    Console.Write("  |  [" + Matriz[f, c] + "] | ");
                    Console.Write("--");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Ejercicio_3 matriz = new Ejercicio_3();
            matriz.CargarMatriz();
            matriz.ImprimirMatriz();
        }
    }
}