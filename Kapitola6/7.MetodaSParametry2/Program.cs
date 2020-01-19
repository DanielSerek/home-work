using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.MetodaSParametry2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 20;
            double y = 5;
            double vysl1 = Podil(x,y);
            double vysl2 = Podil(y,x);
            Console.WriteLine("{0} / {1} = {2}", x, y, vysl1);
            Console.WriteLine("{0} / {1} = {2}", x, y, vysl2);
            Console.ReadKey();
        }

        static double Podil(double delenec, double delitel)
        {
            return delenec / delitel;
        }
    }
}
