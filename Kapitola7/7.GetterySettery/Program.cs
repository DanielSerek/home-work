using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.GetterySettery
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Auto
    {
        // Vlastnost, kterou lze číst i zapisovat z vnějšku třídy
        public string Nazev { get; set; }
        // Vlastnost, kterou lze pouze číst z vnějšku třídy
        public double StavNadrze { get; private set; }
        // 
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
