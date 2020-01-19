using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.PoleGetLength
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vytvoříme pole čísel
            int[] pole = new int[3];
            pole[0] = 4;
            pole[1] = 8;
            pole[2] = 16;

            // Pro zjištění velikosti pole využijeme metodu GetLength
            Console.WriteLine("Velikost pole: {0}", pole.GetLength(0));
            Console.WriteLine("Cisla v poli:");
            for (int i = 0; i < pole.GetLength(0); i++)
            {
                Console.WriteLine(pole[i]);
            }
            Console.ReadKey();
        }
    }
}
