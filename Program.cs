using System;
using System.Linq;

namespace Cap7
{
    class Ejercicio1
    {
        static void Main(string[] args)
{
    int[] nota = new int[15];
    int N, max = nota[0], min = nota[0];
    for(int i = 0; i < 15; i++)
    {
        Console.Write("ingresos de la nota: ");
        N = int.Parse(Console.ReadLine());
        nota[i] = N;
    }

    Console.Write("\n\nLa nota maxima es: " + nota.Max());
    Console.Write("\n\nLa nota minima es: " + nota.Min());
    Console.ReadKey();
}
    }
}

