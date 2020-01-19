using System;
using System.Collections.Generic;
using System.Text;

namespace Třídy
{
    class Zak : Osoba
    {
        public Trida Trida { get; set; }
        public Dictionary<Predmet, List<int>> Znamky { get; set; }

        public Zak(string jmeno, string prijmeni, DateTime datumNarozeni, Trida trida, Dictionary<Predmet, List<int>> znamky)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            DatumNarozeni = datumNarozeni;
            Trida = trida;
            Znamky = znamky;
        }
    }
}
