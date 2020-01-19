using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrvniProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = new string[10];
            data[0] = "Karel 602545447";
            data[1] = "Roman 604555447";
            data[2] = "Katka 737545447";
            data[3] = "Franta 605225447";
            data[4] = "Lucka 737545447";
            data[5] = "Honza 776545132";
            data[6] = "Jirka 777123456";
            data[7] = "Radka 603545447";
            data[8] = "Kristina 776785210";
            data[9] = "Dan 602387831";
          

            int citac = 0;
            string pokracovat;
            bool preruseni = false;

            foreach (string prvek in data)
            {
                Console.WriteLine(prvek);
                if ((citac + 1) % 5 == 0)
                {
                    Console.Write("pokracovat? ");
                    pokracovat = Console.ReadLine();

                    if (pokracovat == "n")
                    {
                        preruseni = true;
                        break;
                    }
                    if (preruseni == true)
                    {
                        break;
                    }
                }
                citac++;
            }
            Console.ReadKey();
        }
    }
}
