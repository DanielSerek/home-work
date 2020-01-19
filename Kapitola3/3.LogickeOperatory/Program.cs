using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.LogickeOperatory
{
    class Program
    {
        static void Main(string[] args)
        {
            bool vyraz1 = !(5 >= 4);
            Console.WriteLine("!(5 >= 4) : {0}", vyraz1);
            bool vyraz2 = !(5 < 4);
            Console.WriteLine("!(5 < 4) : {0}", vyraz2);

            int cenaPizzy = 150;
            bool otevreno = true;
            int penize = 500;
            bool vyraz3 = ((cenaPizzy < penize) && (otevreno == true));
            Console.WriteLine("((cenaPizzy < penize) && (otevreno == true)) : {0}", vyraz3);

            bool vyraz4 = ((penize > cenaPizzy) && (otevreno != false));
            Console.WriteLine("((penize > cenaPizzy) && (otevreno != false)) : {0}", vyraz4);

            bool vyraz5 = ((5 > 4) && (3 < 2));
            Console.WriteLine("((5 > 4) && (3 < 2)) : {0}", vyraz5);

            bool vyraz6 = ((3 > 4) && (3 < 2));
            Console.WriteLine("((3 > 4) && (3 < 2)) : {0}", vyraz6);

            bool vyraz7 = ((5 > 4) || (3 < 2));
            Console.WriteLine("((5 > 4) || (3 < 2)) : {0}", vyraz7);

            bool vyraz8 = ((5 > 4) || (1 < 2));
            Console.WriteLine("((5 > 4) || (1 < 2)) : {0}", vyraz8);

            bool vyraz9 = ((1 > 4) || (3 < 2));
            Console.WriteLine("((1 > 4) || (3 < 2)) : {0}", vyraz9);

            Console.ReadKey();
        }
    }
}
