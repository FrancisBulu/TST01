using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postnummer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een postnummer in");
            string lijn = new String('-', 25);
            Console.WriteLine(lijn);
            //DECLARATION & INITIALIZATION
            int[] postNummer = { 9300, 2000, 1000, 9200, 9000, 8500, 9700, 2300 };
            string[] stad = { "Aalst", "Antwerpen", "Brussel", "Dendermonde", "Gent", "Kortrijk", "Oudenaarde", "Turnhout" };
            int value = int.Parse(Console.ReadLine());
            int pos = Array.IndexOf(postNummer, value);
            //PROCESSING
            for (int i = 0; i < postNummer.Length; i++)
            {
                try
                {
                    postNummer[i] = value;
                    Console.WriteLine($"De stad van deze postnummer is: {stad[pos]}");
                    break;
                }
                catch
                {
                    Console.WriteLine("De postnummer bestaat niet");
                    break;
                }
            }
        }
    }
}
