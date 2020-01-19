using System;

namespace _5.PublicPrivateMetody
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto1 = new Auto("Male auto", 2.7, 50);
            auto1.UjedVzdalenost(100);
            auto1.VypisInformace();
            auto1.UjedVzdalenost(200);
            auto1.VypisInformace();
            Console.ReadKey();
        }
    }

    class Auto
    {
        string nazev;
        double spotreba;
        double stavNadrze;
        double ujetoKm;

        // Konstruktor třídy Auto
        public Auto(string nazev, double spotreba,double stavNadrze)
        {
            this.nazev = nazev;
            this.spotreba = spotreba;
            this.stavNadrze = stavNadrze;
            ujetoKm = 0;
        }

        public void UjedVzdalenost(double pocetKm)
        {
            SpotrebujPalivo(pocetKm);
            ujetoKm += pocetKm;
        }

        private void SpotrebujPalivo(double pocetKm)
        {
            // Vypočítáme spotřebované palivo
            double spotrebovanePalivo = pocetKm / 100 * spotreba;
            // Ubereme palivo z nádrže
            stavNadrze = stavNadrze - spotrebovanePalivo;
        }

        public void VypisInformace()
        {
            Console.WriteLine("Auto: {0}. Ujeto km: {1}. Stav nadrze: {2}.",nazev,ujetoKm,stavNadrze);
        }
    }
}
