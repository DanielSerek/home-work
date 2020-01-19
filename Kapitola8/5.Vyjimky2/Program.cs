using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vyjimky2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadejte prvni cislo: ");
            int x = Int32.Parse(Console.ReadLine());
            Console.Write("Zadejte druhe cislo: ");
            int y = Int32.Parse(Console.ReadLine());
            try
            {
                int vysledek = x / y;
                Console.WriteLine("{0} / {1} = {2}", x, y, vysledek);
            }
            catch(Exception e)
            {
                Console.WriteLine("Doslo k vyjimce: {0}", e.Message);
            }
            Console.ReadKey();
        }
    }
}
