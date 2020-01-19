using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Cviceni1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Pocet cisel: ");
            int pocetCisel = Int32.Parse(Console.ReadLine());
            // Připravíme si pole na zadaná čísla
            int[] poleCisel = new int[pocetCisel];
            // Načteme daný počet čísel a uložíme si je do pole
            for (int i = 0; i < pocetCisel; i++)
            {
                Console.Write("{0}. cislo: ", i + 1);
                poleCisel[i] = Int32.Parse(Console.ReadLine());
            }
            // Nalezneme nejmenší číslo v poli
            int min = poleCisel[0];
            for (int i = 0; i < poleCisel.GetLength(0); i++)
            {
                if (poleCisel[i] < min)
                {
                    min = poleCisel[i];
                }
            }
            // Nalezneme největší číslo v poli
            int max = poleCisel[0];
            for (int i = 0; i < poleCisel.GetLength(0); i++)
            {
                if (poleCisel[i] > max)
                {
                    max = poleCisel[i];
                }
            }

            Console.WriteLine("Nejmensi cislo: {0}", min);
            Console.WriteLine("Nejvetsi cislo: {0}", max);
            Console.ReadKey();
        }
    }
}
