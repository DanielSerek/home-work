using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.CyklusForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            // Připravíme si pole čísel
            int[] poleCisel = new int[3];
            poleCisel[0] = 3;
            poleCisel[1] = 7;
            poleCisel[2] = 17;
            // Připravíme si pole řetězců
            string[] poleRetezcu = new string[4];
            poleRetezcu[0] = "jedna";
            poleRetezcu[1] = "dva";
            poleRetezcu[2] = "tri";
            poleRetezcu[3] = "ctyri";

            Console.WriteLine("Pole cisel obsahuje nasledujici prvky:");
            // Projdeme jednotlivé prvky pole. V každém běhu cyklu
            // budeme mít v proměnné prvek právě jeden prvek z pole
            // a můžeme s ním v těle cyklu pracovat
            foreach (int prvek in poleCisel)
            {
                Console.WriteLine(prvek);
            }

            Console.WriteLine("Pole retezcu obsahuje nasledujici prvky:");
            foreach (string prvek in poleRetezcu)
            {
                Console.WriteLine(prvek);
            }

            Console.ReadKey();
        }
    }
}
