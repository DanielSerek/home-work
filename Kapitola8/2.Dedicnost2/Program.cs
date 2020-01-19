using System;

namespace _2.Dedicnost2
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto("Cervene auto", 180, 4);
            Kamion kamion = new Kamion("Velky kamion", 140, 40);
            auto.Jizda();
            auto.OtevritKufr();
            kamion.Jizda();
            kamion.PripojitNaves();
            Console.ReadKey();
        }
    }

    class DopravniProstredek
    {
        public string Nazev { get; set; }
        public int MaxRychlost { get; set; }

        public void Jizda()
        {
            Console.WriteLine("Dopravni prostredek jede...");
        }
    }

    class Auto : DopravniProstredek
    {
        
        public int PocetOsob { get; set; }

        public Auto(string nazev, int maxRychlost, int pocetOsob)
        {
            Nazev = nazev;
            MaxRychlost = maxRychlost;
            PocetOsob = pocetOsob;
        }

        public void OtevritKufr()
        {
            Console.WriteLine("Otevira se kufr");
        }
    }

    class Kamion : DopravniProstredek
    {
        public int MaxVahaNakladu { get; set; }

        public Kamion(string nazev, int maxRychlost, int maxVahaNakladu)
        {
            Nazev = nazev;
            MaxRychlost = maxRychlost;
            MaxVahaNakladu = maxVahaNakladu;
        }

        public void PripojitNaves()
        {
            Console.WriteLine("Pripojuje se naves");
        }
    }
}
