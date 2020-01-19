using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.CyklusWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Syntaxe cyklu while
              
              while (logický výraz)
              {
                // Příkazy v těle cyklu    
              }
            */

            string provestVypocet = "ano";
            while (provestVypocet == "ano")
            {
                Console.Write("Zadejte prvni cislo: ");
                int x = Int32.Parse(Console.ReadLine());
                Console.Write("Zadejte druhe cislo: ");
                int y = Int32.Parse(Console.ReadLine());
                Console.Write("Zadejte pozadovanou operaci ( + - * / ): ");
                string operace = Console.ReadLine();

                switch (operace)
                {
                    case "+":
                        Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
                        break;
                    case "-":
                        Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
                        break;
                    case "*":
                        Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
                        break;
                    case "/":
                        Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
                        break;
                    default:
                        Console.WriteLine("Byla zadana neznama operace.");
                        break;
                }
                Console.Write("Chce provest dalsi vypocet? (ano/ne): ");
                provestVypocet = Console.ReadLine();
            }
            Console.ReadKey();
            
            int soucet = 0;
            Console.Write("Zadejte cislo: ");
            int cislo = int.Parse(Console.ReadLine());
            while (cislo > 0)
            {
                Console.WriteLine("Soucet = {0} + {1}", soucet, cislo);
                soucet = soucet + cislo;
                cislo = cislo - 1;
            }
            Console.WriteLine("Soucet = {0}", soucet);
            Console.ReadKey();
        }
    }
}
