using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.KolekceDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vytvoření nového slovníku
            Dictionary<string, Auto> auta = new Dictionary<string, Auto>();
            
            Auto auto1 = new Auto("Modre auto", "5B11234");
            Auto auto2 = new Auto("Cervene auto", "7D17834");
            Auto auto3 = new Auto("Zelene auto", "3O22888");
            
            // Přidání prvků do slovníku
            auta.Add(auto1.SPZ, auto1);
            auta.Add(auto2.SPZ, auto2);
            auta.Add(auto3.SPZ, auto3);

            Console.Write("Hledana SPZ: ");
            string spz = Console.ReadLine();
            if (auta.ContainsKey(spz))
            {
                Console.WriteLine("Auto nalezeno. Nazev auta: {0}", auta[spz].Nazev);
            }
            else
            {
                Console.WriteLine("Auto nenalezeno");
            }

            // Vrátí true/false podle toho zdali slovník obsahuje danou hodnotu
            Console.Write("auta.ContainsValue(auto1): ");
            Console.WriteLine(auta.ContainsValue(auto1));

            // Vrátí počet dvojic klíč-hodnota ve slovníku
            Console.Write("auta.Count: ");
            Console.WriteLine(auta.Count);

            // Odstraní hodnotu uloženou pod daným klíčem
            auta.Remove("3O22888");

            // Odstraní všechny klíče-hodnoty ze slovníku
            auta.Clear();

            // Po smazání pomocí metody Clear si znovu přidáme prvky do slovníku
            auta.Add(auto1.SPZ, auto1);
            auta.Add(auto2.SPZ, auto2);
            auta.Add(auto3.SPZ, auto3);

            Console.WriteLine("Iterace skrze auta.Values");
            // Iterace skrze hodnoty je slovníku
            foreach (Auto auto in auta.Values)
            {
                Console.WriteLine("{0}", auto.Nazev);
            }

            Console.WriteLine("Iterace skrze auta.Keys");
            // Iterace skrze klíče ve slovníku
            foreach (string klicSPZ in auta.Keys)
            {
                Auto auto = auta[klicSPZ];
                Console.WriteLine("Klic: {0}, auto: {1}", klicSPZ, auto.Nazev);
            }

            Console.ReadKey();
        }
    }

    class Auto
    {
        public string Nazev { get; set; }
        public string SPZ { get; set; }

        public Auto(string nazev, string spz)
        {
            Nazev = nazev;
            SPZ = spz;
        }
    }
}
