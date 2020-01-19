using System;

namespace _5.PlatnostPromennych2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 15;
            int soucet = SoucetCisel();
            Console.WriteLine("x: {0}", x);
            Console.WriteLine("soucet: {0}", soucet);
            Console.ReadKey();
        }

        static int SoucetCisel()
        {
            Console.Write("1. cislo: ");
            int x = Int32.Parse(Console.ReadLine());
            Console.Write("2. cislo: ");
            int y = Int32.Parse(Console.ReadLine());
            return x + y;
        }
    }
}
