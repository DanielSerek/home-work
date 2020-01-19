using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _1.NacteniSouboru
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = new StreamReader("zamestnanci.txt");
            string radek = streamReader.ReadLine();
            Console.WriteLine("1. radek ze souboru:");
            Console.WriteLine(radek);
            Console.ReadKey();
        }
    }
}
