using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.StatickeVlastnostiPromenne1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Máme tři instance třídy auto přičemž každá má své 
            // vlastnosti Nazev a MaxRychlost ve kterych ma ulozeno
            // jak se jmenuje a jakou má maximální rychlost
            Auto auto1 = new Auto("Zelene auto", 160);
            Auto auto2 = new Auto("Modre auto", 180);
            Auto auto3 = new Auto("Cervene auto", 170);

            Console.WriteLine("auto1: {0} ({1})", auto1.Nazev, auto1.MaxRychlost);
            Console.WriteLine("auto2: {0} ({1})", auto2.Nazev, auto2.MaxRychlost);
            Console.WriteLine("auto3: {0} ({1})", auto3.Nazev, auto3.MaxRychlost);
            Console.ReadKey();
        }
    }

    class Auto
    {
        public string Nazev { get; private set; }
        public int MaxRychlost { get; private set; }

        public Auto(string nazev, int maxRychlost)
        {
            Nazev = nazev;
            MaxRychlost = maxRychlost;
        }
    }
}
