using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.NacteniSouboruVyjimky
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader("zamestnanci.txt");
                Console.WriteLine("Obsah souboru: ");
                string radek = "";
                while ((radek = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(radek);
                }
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Doslo k neocekavane vyjimce: {0}", e.Message);
            }
            finally
            {
                if (streamReader != null)
                {
                    streamReader.Close();
                }
            }
        }
    }
}