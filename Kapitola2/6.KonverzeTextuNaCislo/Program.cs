using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonverzeTextuNaCislo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("Zadejte prvni cislo: ");
            string cislo1 = Console.ReadLine();
            Console.Write("Zadejte druhe cislo: ");
            string cislo2 = Console.ReadLine();
            // Toto je špatně. Násobení řetězců nedává smysl. Je zapotřebí převod na čísla
            string vysledek = cislo1 * cislo2;
            */

            
            Console.Write("Zadejte prvni cele cislo: ");
            string retezecCislo1 = Console.ReadLine();
            int cislo1 = Int32.Parse(retezecCislo1);
            // Návratovou hodnotu metody ReadLine si nemusíme ukládat do proměnné, 
            // ale můžeme ji rovnou předat metodě Parse
            Console.Write("Zadejte druhe cele cislo: ");
            int cislo2 = Int32.Parse(Console.ReadLine());
            int soucin = cislo1 * cislo2;
            Console.WriteLine("{0} * {1} = {2}", cislo1, cislo2, soucin);
            Console.ReadKey();
            
            
            Console.WriteLine("Zadejte prvni desetinne cislo: ");
            string retezecDesCislo1 = Console.ReadLine();
            float desCislo1 = float.Parse(retezecDesCislo1);
            Console.WriteLine("Zadejte druhe desetinne cislo: ");
            // Návratovou hodnotu metody ReadLine si nemusíme ukládat do proměnné, 
            // ale můžeme ji rovnou předat metodě Parse
            float desCislo2 = Single.Parse(Console.ReadLine());
            float soucetDesCisel = desCislo1 + desCislo2;
            Console.WriteLine("{0} + {1} = {2}", desCislo1, desCislo2, soucetDesCisel);
            Console.ReadKey();
             
        }
    }
}
