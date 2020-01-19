using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.ZapisDoSouboru1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> studenti = new List<string>(new string[] {"Pavel","Anna","Petr","Magda","Jindrich","Marie" });
            StreamWriter streamWriter = null;
            try
            {
                streamWriter = new StreamWriter("studenti.txt");
                foreach (string student in studenti)
                {
                    streamWriter.WriteLine(student);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Nastala neocekavana vyjimka: {0}", e.Message);
            }
            finally
            {
                if (streamWriter != null)
                {
                    streamWriter.Close();
                }
            }
        }
    }
}
