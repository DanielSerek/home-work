using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Cviceni1
{
    class Zak : Osoba
    {
        public Trida Trida { get; set; }
        public Dictionary<Predmet, List<int>> Znamky { get; set; }

        public Zak(string jmeno, string prijmeni,DateTime datumNarozeni,Trida trida, Dictionary<Predmet,List<int>> znamky)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            DatumNarozeni = datumNarozeni;
            Trida = trida;
            Znamky = znamky;
        }
    }
}
