using System;
using System.Collections.Generic;

namespace Třídy
{
    class Program
    {
        static void Main(string[] args)
        {
            Ucebna ucebna1 = new Ucebna("323", "dataprojektor", 20);
            Ucebna ucebna2 = new Ucebna("324", "televize, flipchart", 10);

            Predmet predmet1 = new Predmet("Matematika", "637", "zaklady matematiky pro 2.stupeň", 6);
            Predmet predmet2 = new Predmet("Dějepis", "638", "dějepis pro 2. stupeň", 8);

            Dictionary<Predmet, List<int>> zak1Znamky = new Dictionary<Predmet, List<int>>();
            List<int> znamkyPredmet1 = new List<int> { 1, 2, 3, 2 };
            List<int> znamkyPredmet2 = new List<int> { 2, 3, 4, 5 };
            zak1Znamky.Add(predmet1, znamkyPredmet1);
            zak1Znamky.Add(predmet2, znamkyPredmet2);

            Dictionary<Predmet, List<int>> zak2Znamky = new Dictionary<Predmet, List<int>>();
            zak2Znamky.Add(predmet1, znamkyPredmet1);
            zak2Znamky.Add(predmet1, znamkyPredmet2);


          

            List<Predmet> vyucovanePredmetyUcitel1 = new List<Predmet> { predmet1, predmet2 };

            //public Ucitel(string jmeno, string prijmeni, DateTime datumNarozeni, string titulPredJmenem, string titulZaJmenem, Trida hlavniTrida, List<Predmet> vyucovanePredmety)
            Ucitel ucitel1 = new Ucitel("Jaroslav", "Svěcený", 1960, 08, 08, "Ing.", "", A1, vyucovanePredmetyUcitel1);

            Trida A1 = new Trida("A1", 1, A1, ucitel1);

            //public Zak(string jmeno, string prijmeni, DateTime datumNarozeni, Trida trida, Dictionary<Predmet, List<int>> znamky)
            DateTime zak1birthday = new DateTime(1974, 7, 10, 7, 10, 24);
            DateTime zak2birthday = new DateTime(1800, 6, 5, 0, 0, 0);
            Zak zak1 = new Zak("Petr", "Malý", zak1birthday, A1, zak1Znamky);
            Zak zak2 = new Zak("Roman", "Holý", zak2birthday, A1, zak2Znamky);


            List<Zak> zaci = new List<Zak>();
            // to be solved... how to add zaci into this "zaci"
            

            Dictionary<Trida, Ucitel> uciteleTrid = new Dictionary<Trida, Ucitel>();
            // to be solved...
            //zaci.Add(A1, ucitel1);
            //zaci.Add(A1, ucitel2);

            Dictionary<Ucitel, Predmet> vyucovanePredmety = new Dictionary<Ucitel, Predmet>();
            // how to add vyucovane predmety... vyucovanePredmety.Add(ucitel1, predmet1);

            

            

            


            
            
           


            





        }
    }
}
