using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetterySettery2
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto("Cervene auto", 5, 50);
            Console.WriteLine("Nazev auta: {0}",auto.Nazev);
            Console.WriteLine("Nazev auta: {0}", auto.Nazev);
            Console.WriteLine("Stav nadrze: {0}", auto.StavNadrze);
            Console.ReadKey();
        }
    }

    class Auto
    {
        private string nazev;
        // Vlastnost, kterou lze číst i zapisovat z vnějšku třídy
        public string Nazev 
        {
            get
            {
                Console.WriteLine("Nazev.get");
                return nazev;
            }
            set
            {
                Console.WriteLine("Nazev.set");
                nazev = value;
            }
        
        }
        private double stavNadrze;
        // Vlastnost, kterou lze pouze číst z vnějšku třídy
        public double StavNadrze
        {
            get
            {
                return stavNadrze;
            }
            private set
            {
                stavNadrze = value;
            }
        }
        private double spotreba;
        private double ujetoKm;

        // Konstruktor třídy Auto
        public Auto(string nazev, double spotreba, double stavNadrze)
        {
            Nazev = nazev;
            StavNadrze = stavNadrze;
            this.spotreba = spotreba;
            ujetoKm = 0;
        }
    }
}
