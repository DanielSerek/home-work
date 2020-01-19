using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.StatickeMetody
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] znamky = new int[4];
            znamky[0] = 3;
            znamky[1] = 4;
            znamky[2] = 1;
            znamky[3] = 2;
            Console.WriteLine("Prumer: {0}",Kalkulacka.AritmetickyPrumer(znamky));
            Console.ReadKey();
        }
    }

    class Kalkulacka
    {
        public static double AritmetickyPrumer(int[] cisla)
        {
            double soucet = 0;
            foreach(int cislo in cisla)
            {
                soucet += cislo;
            }
            return soucet / cisla.Length;
        }
    }
}
