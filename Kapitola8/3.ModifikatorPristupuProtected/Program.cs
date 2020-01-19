using System;

namespace _3.ModifikatorPristupuProtected
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto("Cervene auto", 180, 4);
            Kamion kamion = new Kamion("Velky kamion", 140, 40);
            // Nelze nastavit, protože Nazev i MaxRychlost maji setter protected
            // a lze je nastavit pouze ze třídy DopravniProstredek nebo jejich potomku
            // auto.Nazev = "Novy nazev";
            // kamion.MaxRychlost = 200;
            
            Console.ReadKey();
        }
    }

    class DopravniProstredek
    {
        public string Nazev { get; protected set; }
        public int MaxRychlost { get; protected set; }

        public void Jizda()
        {
            Console.WriteLine("Dopravni prostredek jede...");
        }
    }

    class Auto : DopravniProstredek
    {

        public int PocetOsob { get; protected set; }

        public Auto(string nazev, int maxRychlost, int pocetOsob)
        {
            // Nazev i MaxRychlost muzeme nastavit, protože Auto dědí z DopravniProstredek
            // a tedy může přistoupit k prvkům, které mají modifikátor přístupu protected
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
        public int MaxVahaNakladu { get; protected set; }

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
