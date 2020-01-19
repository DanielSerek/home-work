using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Cviceni3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Výpisy na konzoli jsou platné ke spuštění 5.8.2015
            Narozeniny(new DateTime(1990, 12, 12));
            Narozeniny(new DateTime(1985, 8, 10));
            Narozeniny(new DateTime(1974, 5, 30));
            Narozeniny(new DateTime(1988, 7, 11));
            Console.ReadKey();
        }

        static void Narozeniny(DateTime datumNarozeni)
        {
            int pocetLet = DateTime.Now.Year - datumNarozeni.Year;
            Console.WriteLine("Pocet let: {0}", pocetLet);
            if (datumNarozeni.Date == DateTime.Now.Date)
            {
                Console.WriteLine("Blahopreji k narozeninam");
            }
            else
            {
                Console.Write("Pocet dni do narozenin: ");
                if(datumNarozeni.Date.DayOfYear > DateTime.Now.Date.DayOfYear)
                {
                    Console.WriteLine(datumNarozeni.DayOfYear - DateTime.Now.DayOfYear);
                }
                else
                {
                    Console.WriteLine(365 - (DateTime.Now.DayOfYear - datumNarozeni.DayOfYear));
                }
            }
        }
    }
}
