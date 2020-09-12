using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
        
            Console.Write("Dijite el numero");
            n=int.Parse(Console.ReadLine());
        if(n % 2==0)
                {
                Console.WriteLine("Es par");
            }
        else
            {
                Console.WriteLine("es impar");

            }
            Console.ReadKey();
    }
}
        }
    }
    
}
