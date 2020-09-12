using System;

namespace capitulo2
{
    class Program
    {
        static void Main(string[] args)
        {
            double Cantidad, Perimetro, Lado

            Console.Write("Lado:");
            Lado=double.Parse(Console.ReadLine());
            Console.Write("Cantidad:");
            Cantidad=double.Parse(Console.ReadLine);
            Perimetro=Lado*Cantidad;
            Perimetro=WriteLine("perimetro={0}", Perimetro);
            Console.ReadKey();
            

        }
    }
}
