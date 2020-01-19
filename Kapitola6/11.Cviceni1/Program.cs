using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Cviceni1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] mzdyZamestnancu = { 15500, 18500, 23000, 14000, 38000, 20000 };
            Console.WriteLine("Prumerna mzda: {0}", PrumernaMzda(mzdyZamestnancu));
            Console.WriteLine("Nejnizsi mzda: {0}", MinMzda(mzdyZamestnancu));
            Console.WriteLine("Nejvyssi mzda: {0}", MaxMzda(mzdyZamestnancu));
            Console.ReadKey();
        }

        static double PrumernaMzda(double[] mzdy)
        {
            if (mzdy.Length > 0)
            {
                double soucet = 0;
                foreach (double mzda in mzdy)
                {
                    soucet += mzda;
                }
                return soucet / mzdy.Length;
            }
            else
            {
                return 0;
            }
        }

        static double MinMzda(double[] mzdy)
        {
            if (mzdy.Length > 0)
            {
                double min = mzdy[0];
                foreach (double mzda in mzdy)
                {
                    if (mzda < min)
                    {
                        min = mzda;
                    }
                }
                return min;
            }
            else
            {
                return 0;
            }
        }

        static double MaxMzda(double[] mzdy)
        {
            if (mzdy.Length > 0)
            {
                double max = mzdy[0];
                foreach (double mzda in mzdy)
                {
                    if (mzda > max)
                    {
                        max = mzda;
                    }
                }
                return max;
            }
            else
            {
                return 0;
            }
        }
    }
}
