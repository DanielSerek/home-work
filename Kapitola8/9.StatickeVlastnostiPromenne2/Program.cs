using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.StatickeVlastnostiPromenne2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Všimněte si, že nepřistupujeme k instanci třídy Auto, ale
            // přímo k vlastnosti třídy samotné
            Console.WriteLine("Pocet vytvorenych aut: {0}", Auto.PocetAut);
            
            // Máme tři instance třídy auto, přičemž každá má své
            // vlastnosti Nazev a MaxRychlost, ve kterých má uloženo,
            // jak se jmenuje a jakou má maximální rychlost
            Auto auto1 = new Auto("Zelene auto", 160);
            Console.WriteLine("Pocet vytvorenych aut: {0}", Auto.PocetAut);
            Auto auto2 = new Auto("Modre auto", 180);
            Auto auto3 = new Auto("Cervene auto", 170);
            Console.WriteLine("Pocet vytvorenych aut: {0}", Auto.PocetAut);
            Console.ReadKey();
        }
    }

    class Auto
    {
        public string Nazev { get; private set; }
        public int MaxRychlost { get; private set; }
        public static int PocetAut { get; private set; }

        public Auto(string nazev, int maxRychlost)
        {
            Nazev = nazev;
            MaxRychlost = maxRychlost;
            PocetAut++;
        }
    }
}
