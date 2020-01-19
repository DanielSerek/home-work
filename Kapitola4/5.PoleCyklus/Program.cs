using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.PoleCyklus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadejte pocet cisel: ");
            int pocetCisel = Int32.Parse(Console.ReadLine());
            // Vytvoříme pole u nejž velikost nastavíme dle počtu čísel
            // které chce uživatel zadat
            int[] poleCisel = new int[pocetCisel];

            // V této proměnné budeme udržovat aktuální součet 
            // zadaných čísel
            int soucet = 0;

            // proměnnou i nastavíme záměrně na nulu abychom plnili pole od nultého 
            // indexu, protože víme, že se polí indexují nikoliv od jedničky,
            // ale od nuly
            for (int i = 0; i < pocetCisel; i++)
            {
                Console.Write("Zadejte cislo: ");
                int cislo = Int32.Parse(Console.ReadLine());
                // Číslo načtené od uživatele uložíme do pole
                poleCisel[i] = cislo;
                soucet = soucet + cislo;
            }
            Console.WriteLine("Soucet je: {0}", soucet);
            Console.ReadKey();
        }
    }
}
