using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.ZapisDoSouboru2
{
    class Student
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public int Rocnik { get; set; }
        public string Obor { get; set; }

        public Student(string jmeno, string prijmeni, int rocnik, string obor)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Rocnik = rocnik;
            Obor = obor;
        }
    }
}
