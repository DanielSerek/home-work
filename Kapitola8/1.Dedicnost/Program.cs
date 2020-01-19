using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Dedicnost1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Auto
    {
        public string Nazev { get; set; }
        public int MaxRychlost { get; set; }
        public int PocetOsob { get; set; }

        public Auto(string nazev, int maxRychlost, int pocetOsob)
        {
            Nazev = nazev;
            MaxRychlost = maxRychlost;
            PocetOsob = pocetOsob;
        }

        public void Jizda()
        {
            Console.WriteLine("Dopravni prostredek jede...");
        }

        public void OtevritKufr()
        {
            Console.WriteLine("Otevira se kufr");
        }
    }

    class Kamion
    {
        public string Nazev { get; set; }
        public int MaxRychlost { get; set; }
        public int MaxVahaNakladu { get; set; }

        public Kamion(string nazev, int maxRychlost, int maxVahaNakladu)
        {
            Nazev = nazev;
            MaxRychlost = maxRychlost;
            MaxVahaNakladu = maxVahaNakladu;
        }

        public void Jizda()
        {
            Console.WriteLine("Dopravni prostredek jede...");
        }

        public void PripojitNaves()
        {
            Console.WriteLine("Pripojuje se naves");
        }
    }
}
