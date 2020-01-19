using System;

namespace _6.MetodaSParametry1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1. cislo: ");
            int cislo1 = Int32.Parse(Console.ReadLine());
            Console.Write("2. cislo: ");
            int cislo2 = Int32.Parse(Console.ReadLine());
            int soucet = Soucet(cislo1, cislo2);
            Console.WriteLine("{0} + {1} = {2}", cislo1, cislo2, soucet);
            Console.ReadKey();
        }

        static int Soucet(int x, int y)
        {
            return x + y;
        }
    }
}
