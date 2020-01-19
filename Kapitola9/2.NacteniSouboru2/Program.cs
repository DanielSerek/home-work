using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.NacteniSouboru2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = new StreamReader("zamestnanci.txt");

            Console.WriteLine("Obsah souboru: ");
            string radek = "";
            while ((radek = streamReader.ReadLine()) != null)
            {
                Console.WriteLine(radek);
            }
            Console.ReadKey();
        }
    }
}
