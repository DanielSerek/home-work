using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NacteniVstupuOdUzivatele
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadejte jmeno: ");
            string jmeno = Console.ReadLine();
            Console.WriteLine("Zadane jmeno bylo: {0}", jmeno);
            Console.ReadKey();
        }
    }
}
