using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.PublicPrivatePromenne
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto1 = new Auto("Modre auto", 4.7, 50);
            Auto auto2 = new Auto("Zelene auto", 5.1, 45);

            auto1.nazev = "Cervene auto";
            auto2.stavNadrze = 40;
            // Toto nelze. Proměnná spotreba je private a nelze k ní z vnějšku přistoupit
            // auto1.spotreba = 5;

            Console.WriteLine("auto1.nazev: {0}", auto1.nazev);
            Console.WriteLine("auto1.stavNadrze: {0}", auto1.stavNadrze);
            Console.WriteLine("auto2.nazev: {0}", auto2.nazev);
            Console.WriteLine("auto2.stavNadrze: {0}", auto2.stavNadrze);
            Console.ReadKey();
        }
    }

    class Auto
    {
        public string nazev;
        public double stavNadrze;
        private double spotreba;
        private double ujetoKm;

        // Konstruktor třídy Auto
        public Auto(string nazev, double spotreba, double stavNadrze)
        {
            this.nazev = nazev;
            this.spotreba = spotreba;
            this.stavNadrze = stavNadrze;
            ujetoKm = 0;
        }
    }
}
