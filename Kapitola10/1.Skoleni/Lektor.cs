using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Skoleni
{
    public class Lektor : Zamestnanec
    {
        public List<Skoleni> VyucovanaSkoleni { get; set; }

        public Lektor(string jmeno, string prijmeni, string kod, string nazevPozice)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Kod = kod;
            NazevPozice = nazevPozice;
            VyucovanaSkoleni = new List<Skoleni>();
        }
    }
}
