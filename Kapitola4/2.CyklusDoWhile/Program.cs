using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.CyklusDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Syntaxe cyklu do-while
              
              do
              {
                // Příkazy v těle cyklu    
              } while (logický výraz)
              
            */

            string provestVypocet;
            do
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
            } while (provestVypocet == "ano");
        }
    }
}
