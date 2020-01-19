﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Třídy
{
    class Predmet
    {
        public string Nazev { get; set; }
        public string Kod { get; set; }
        public string Popis { get; set; }
        public int Rocnik { get; set; }

        public Predmet(string nazev, string kod, string popis, int rocnik)
        {
            Nazev = nazev;
            Kod = kod;
            Popis = popis;
            Rocnik = rocnik;
        }
    }
}
