using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Vyjimky1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadejte prvni cislo: ");
            int x = Int32.Parse(Console.ReadLine());
            Console.Write("Zadejte druhe cislo: ");
            int y = Int32.Parse(Console.ReadLine());
            if (y != 0)
            {
                int vysledek = x / y;
                Console.WriteLine("{0} / {1} = {2}", x, y, vysledek);
            }
            else
            {
                Console.WriteLine("Nelze delit nulou");
            }
            Console.ReadKey();
        }
    }
}
