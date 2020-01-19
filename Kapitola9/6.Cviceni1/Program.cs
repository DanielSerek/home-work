using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Cviceni1
{
    class Program
    {
        static void Main(string[] args)
        {
            Evidence evidence = new Evidence();

            StreamReader readerFirmy = null;
            StreamReader readerFaktury = null;

            try
            {
                // Načtení firem
                readerFirmy = new StreamReader("firmy.txt");
                string radek = "";
                while ((radek = readerFirmy.ReadLine()) != null)
                {
                    string[] hodnoty = radek.Split(';');
                    string ico = hodnoty[0];
                    string nazev = hodnoty[1];
                    string adresa = hodnoty[2];
                    evidence.PridatFirmu(new Firma(nazev, adresa, ico));
                }

                // Načtení faktur
                readerFaktury = new StreamReader("faktury.txt");
                while ((radek = readerFaktury.ReadLine()) != null)
                {
                    string[] hodnoty = radek.Split(';');
                    string kod = hodnoty[0];
                    string ico = hodnoty[1];
                    double castka = double.Parse(hodnoty[2]);
                    bool zaplaceno = false;
                    if (hodnoty[3].ToLower() == "ano")
                    {
                        zaplaceno = true;
                    }
                    evidence.PridatFakturu(new Faktura(ico,kod,castka,zaplaceno));
                }

                evidence.VypisDluznychFirem();
            }
            catch (Exception e)
            {
                // Nastala výjimka. Pouze vypíšeme informaci. Program dále nepokračuje.
                Console.WriteLine("Nastala vyjimka: {0}. Program bude ukoncen.", e.Message);
            }
            finally
            {
                // V každém případě nezapomeneme zavřít StreamReader
                if (readerFirmy != null)
                {
                    readerFirmy.Close();
                }
                if (readerFaktury != null)
                {
                    readerFaktury.Close();
                }
            }
            Console.ReadKey();
        }
    }
}
