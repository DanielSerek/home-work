using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PrikazBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            int soucet = 0;
            Console.WriteLine("Kolik budete chtit zadat cisel: ");
            int pocetCisel = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Zadavejte cisla. Pro predcasne ukonceni zadejte K");
            for (int i = 0; i < pocetCisel; i++)
            {
                string zadane = Console.ReadLine();
                if(zadane == "K")
                {
                    break;
                }
                soucet = soucet + Int32.Parse(zadane);
            }
            Console.WriteLine("Soucet cisel: {0}",soucet);
            Console.ReadKey();
        }
    }
}
