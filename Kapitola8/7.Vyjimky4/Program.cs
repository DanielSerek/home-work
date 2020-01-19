using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Vyjimky4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listRetezcu = new List<string>();
            listRetezcu.Add("pavel");
            listRetezcu.Add(null);
            listRetezcu.Add("karel");

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("i = {0}", i);
                try
                {
                    Console.WriteLine(listRetezcu[i].ToUpper());
                }
                catch (NullReferenceException e)
                {
                    Console.WriteLine("Odchycena NullReferenceException: ");
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Odchycena Exception: ");
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    Console.WriteLine("Prikazy v bloku finally se vykonaji vzdy");
                }
            }
            Console.ReadKey();
        }
    }
}
