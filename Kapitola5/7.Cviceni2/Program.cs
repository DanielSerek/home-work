using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Cviceni2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Načteme aktuální zaměstnance firmy
            Console.Write("Aktualni pocet zamestnancu: ");
            int aktualniPocet = Int32.Parse(Console.ReadLine());
            string[] aktualniZamestnanci = new string[aktualniPocet];

            for (int i = 0; i < aktualniPocet; i++)
            {
                Console.Write("{0}. zamestnanec: ",i+1);
                aktualniZamestnanci[i] = Console.ReadLine();
            }

            // Načteme nově nastupující zaměstnance
            Console.Write("Pocet novych zamestnancu: ");
            int pocetNovych = Int32.Parse(Console.ReadLine());
            string[] noviZamestnanci = new string[pocetNovych];

            for (int i = 0; i < pocetNovych; i++)
            {
                Console.Write("{0}. zamestnanec: ", i + 1);
                noviZamestnanci[i] = Console.ReadLine();
            }

            // Vytvoříme pole, do kterého uložíme jak stávající tak nově příchozí zaměstnance
            string[] vsichniZamestnanci = new string[aktualniPocet + pocetNovych];
            // Pomocná proměnná ve které budeme uchovávat index na který budeme vkládat do pole
            int citac = 0;
            // Do pole všech zaměstnanců vložíme aktuální zaměstnance
            foreach (string zamestnanec in aktualniZamestnanci)
            {
                vsichniZamestnanci[citac] = zamestnanec;
                citac++;
            }
            // Do pole všech zaměstnanců vložíme nové zaměstnance
            foreach (string zamestnanec in noviZamestnanci)
            {
                vsichniZamestnanci[citac] = zamestnanec;
                citac++;
            }
            // Vypíšeme všechny zaměstnance
            Console.WriteLine("*** Vypis vsech zamestnancu ***");
            foreach (string zamestnanec in vsichniZamestnanci)
            {
                Console.WriteLine(zamestnanec);
            }
            Console.ReadKey();
        }
    }
}
