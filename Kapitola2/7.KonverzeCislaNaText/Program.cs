using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.KonverzeCislaNaText
{
    class Program
    {
        static void Main(string[] args)
        {
            int cislo1 = 5;
            int cislo2 = 10;
            int soucetCisel = cislo1 + cislo2;
            // Výsledek metody ToString si můžeme uložit do proměnné
            string retezec1 = cislo1.ToString();
            string retezec2 = cislo2.ToString();
            string soucetRetezcu = retezec1 + retezec2;
            // Výsledek metody ToString můžeme rovnou použít v dalších příkazech a metodách 
            string soucetRetezcu2 = cislo1.ToString() + cislo2.ToString();

            Console.WriteLine("Soucet cisel = {0}", soucetCisel);
            Console.WriteLine("Soucet retezcu = {0}", soucetRetezcu);
            Console.ReadKey();
        }
    }
}
