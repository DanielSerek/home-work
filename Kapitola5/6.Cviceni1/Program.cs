using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Cviceni1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dolni hranice intervalu: ");
            int dolni = Int32.Parse(Console.ReadLine());
            Console.Write("Horni hranice intervalu: ");
            int horni = Int32.Parse(Console.ReadLine());
            // Vypočteme jak veliké pole budeme potřebovat. 
            // Pokud by uživatel zadat interval např. 4..15 pak by bez
            // přičtení + 1 byl počet prvků roven 11 což je chyba
            int pocetPrvku = horni - dolni + 1;
            // Vytvoříme pole reprezentující daný interval
            int[] interval = new int[pocetPrvku];
            // Naplníme pole čísly z daného intervalu
            for (int i = 0; i < pocetPrvku; i++)
            {
                interval[i] = i + dolni;
            }
            // Pomocí cyklu foreach projdeme a vypíšeme prvky dělitelné třemi
            foreach (int prvek in interval)
            {
                if (prvek % 3 == 0)
                {
                    Console.Write("{0} ", prvek);
                }
            }
            Console.ReadKey();
        }
    }
}
