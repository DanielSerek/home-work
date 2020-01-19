using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Skoleni
{
    public class Student : Zamestnanec
    {
        public List<Skoleni> Skoleni { get; set; }

        public Student(string jmeno, string prijmeni, string kod, string nazevPozice)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Kod = kod;
            NazevPozice = nazevPozice;
            Skoleni = new List<Skoleni>();
        }
    }
}
