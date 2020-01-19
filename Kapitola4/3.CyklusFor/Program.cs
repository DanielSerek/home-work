using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CyklusFor
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Syntaxe cyklu for
              
                for (inicializační výraz ; ukončující logický výraz ; změna řídící proměnné) 
                { 
                    // Příkazy v těle cyklu
                }
            */

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
            

            Console.Write("Zadejte pocet cisel: ");
            int pocetCisel = Int32.Parse(Console.ReadLine());
            int soucet = 0;
            for (int i = 1; i <= pocetCisel; i++)
            {
                Console.Write("Zadejte {0}. cislo: ",i);
                soucet = soucet + Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("Soucet zadanych cisel = {0}", soucet);
            Console.ReadKey();
        }
    }
}
