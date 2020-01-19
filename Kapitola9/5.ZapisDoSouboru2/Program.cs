using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.ZapisDoSouboru2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Připravíme si testovací data o studentech
            List<Student> studenti = new List<Student>();
            studenti.Add(new Student("Karel", "Novak", 2, "Ekonomie a management"));
            studenti.Add(new Student("Jana", "Adamova", 2, "Ekonomie a management"));
            studenti.Add(new Student("Veronika", "Matejovska", 3, "Informacni technologie"));
            studenti.Add(new Student("Josef", "Vyskocil", 2, "Informacni technologie"));
            studenti.Add(new Student("Pavel", "Prochazka", 3, "Ekonomie a management"));

            // Zápis dat o studentech do souboru
            StreamWriter streamWriter = null;
            try
            {
                streamWriter = new StreamWriter("studenti.txt");
                foreach (Student student in studenti)
                {
                    streamWriter.WriteLine("{0};{1};{2};{3}", 
                        student.Jmeno, student.Prijmeni, student.Rocnik, student.Obor);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Nastala neocekavana vyjimka: {0}", e);
            }
            finally
            {
                if (streamWriter != null)
                {
                    streamWriter.Close();
                }
            }

            // Zjistíme zdali soubor s daty o studentech existuje
            if (File.Exists("studenti.txt"))
            {
                List<Student> nacteniStudenti = new List<Student>();
                StreamReader streamReader = null;
                try
                {
                    streamReader = new StreamReader("studenti.txt");
                    string radek = "";
                    while ((radek = streamReader.ReadLine()) != null)
                    {
                        // Hodnoty o jednom studentovi na řádku rozdělíme
                        // pomocí metody Split. Tím získáme pole řetězců.
                        // V tomto polí víme, že prvek na indexu 0 je jméno studenta,
                        // prvek na indexu 2 je příjmení studenta atd.
                        string[] hodnoty = radek.Split(';');
                        string jmeno = hodnoty[0];
                        string prijmeni = hodnoty[1];
                        int rocnik = Int32.Parse(hodnoty[2]);
                        string obor = hodnoty[3];
                        nacteniStudenti.Add(new Student(jmeno, prijmeni, rocnik, obor));
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Nastala neocekavana vyjimka: {0}", e);
                }
                finally
                {
                    if (streamReader != null)
                    {
                        streamReader.Close();
                    }
                }

                Console.WriteLine("Bylo nacteno {0} studentu.", nacteniStudenti.Count);

            }
            else
            {
                Console.WriteLine("Soubor se vstupnimi daty neexistuje");
            }

            Console.ReadKey();
        }
    }
}
