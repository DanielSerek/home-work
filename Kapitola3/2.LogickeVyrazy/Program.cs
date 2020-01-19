
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.LogickeVyrazy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Výsledek logického výrazu si můžeme uložit do proměnné
            bool vysledek1 = 5 < 4;
            // Pomocí Console.WriteLine můžeme vypsat i hodnotu proměnné typu bool
            Console.WriteLine(vysledek1);
            // Pomocí Console.WriteLine můžeme vypsat i přímo výsledek logického výrazu
            Console.WriteLine(5 >= 4);
            
            // Ukázka různých logických výrazů
            int x1 = 5;
            int y1 = 3;
            bool vyraz1 = x1 > y1;
            Console.WriteLine(vyraz1);
            Console.WriteLine(x1 > y1);
            Console.WriteLine("{0} > {1} ... {2}",x1,y1,x1 > y1);

            int x2 = 4;
            int y2 = 4;
            Console.WriteLine(x2 > y2);
            Console.WriteLine("{0} > {1} ... {2}", x2, y2, x2 > y2);
            Console.WriteLine("{0} >= {1} ... {2}", x2, y2, x2 >= y2);
            Console.WriteLine("{0} == {1} ... {2}", x2, y2, x2 == y2);
            Console.ReadKey();
            
            // Porovnání dalších datových typů
            float desCislo1 = 32.1f;
            float desCislo2 = 32.2f;
            Console.WriteLine("{0} > {1} ... {2}", desCislo1, desCislo2, desCislo1 > desCislo2);
            Console.WriteLine("{0} <= {1} ... {2}", desCislo1, desCislo2, desCislo1 <= desCislo2);

            string jmeno1 = "Pavel";
            string jmeno2 = "Karel";
            string jmeno3 = "Pavel";

            Console.WriteLine("{0} == {1} ... {2}", jmeno1, jmeno2, jmeno1 == jmeno2);
            Console.WriteLine("{0} == {1} ... {2}", jmeno1, jmeno3, jmeno1 == jmeno3);

            bool hodnota1 = true;
            bool hodnota2 = false;
            bool hodnota3 = true;
            Console.WriteLine("{0} == {1} ... {2}", hodnota1, hodnota2, hodnota1 == hodnota2);
            Console.WriteLine("{0} == {1} ... {2}", hodnota1, hodnota3, hodnota1 == hodnota3);

            Console.ReadKey();
        }
    }
}
