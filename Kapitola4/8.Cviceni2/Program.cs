using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Cviceni2
{
    class Program
    {
        static void Main(string[] args)
        {

            int volba = 0;
            do
            {
                Console.WriteLine("Vyberte z nasledujici nabidky");
                Console.WriteLine("1. Polozka A");
                Console.WriteLine("2. Polozka B");
                Console.WriteLine("3. Polozka C");
                volba = Int32.Parse(Console.ReadLine());
            } while (volba < 1 || volba > 3);
            Console.WriteLine("Zvolena moznost: {0}", volba);
            Console.ReadKey();
        }
    }
}
