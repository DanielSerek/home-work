using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Cviceni1
{
    class Ucitel : Osoba
    {
        public string TitulPredJmenem { get; set; }
        public string TitulZaJmenem { get; set; }
        public Trida HlavniTrida { get; set; }
        public List<Predmet> VyucovanePredmety { get; set; }


        public Ucitel(string jmeno, string prijmeni,DateTime datumNarozeni,string titulPredJmenem,
            string titulZaJmenem, Trida hlavniTrida, List<Predmet> vyucovanePredmety)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            DatumNarozeni = datumNarozeni;
            TitulPredJmenem = titulPredJmenem;
            TitulZaJmenem = titulZaJmenem;
            HlavniTrida = hlavniTrida;
            VyucovanePredmety = vyucovanePredmety;
        }
    }
}
