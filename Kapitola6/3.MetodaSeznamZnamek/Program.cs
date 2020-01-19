using System;

namespace _3.MetodaSeznamZnamek
{
    class Program
    {
        static void Main(string[] args)
        {
            // Výsledek volání metody si uložíme do proměnné seznamZnamek
            int[] seznamZnamek = ZiskejZnamky();
            Console.WriteLine("Zadane znamky: ");
            for (int i = 0; i < seznamZnamek.Length; i++)
            {
                Console.Write("{0} ", seznamZnamek[i]);
            }
            Console.ReadKey();
        }

        // Návratový typ metody je pole celých čísel
        static int[] ZiskejZnamky()
        {
            Console.Write("Pocet zadavanych znamek: ");
            int pocetZnamek = Int32.Parse(Console.ReadLine());
            int[] znamky = new int[pocetZnamek];
            // Použijeme for cyklus, protože víme přesně kolik známek budeme načítat
            for (int i = 0; i < pocetZnamek; i++)
            {
                Console.Write("{0}. znamka: ", i + 1);
                znamky[i] = Int32.Parse(Console.ReadLine());
            }
            return znamky;
        }
    }
}
