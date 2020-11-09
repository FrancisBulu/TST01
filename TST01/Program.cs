using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TST01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een bedrag in");
            int bedrag = int.Parse(Console.ReadLine());
            if (bedrag>5000)
            {
                int prijs = bedrag - (bedrag * 5 / 100);
                Console.WriteLine($"Totaal te betalen, mind 5% korting: {prijs} EUR");

            }
            else
            {
                Console.WriteLine($"Totaal te betalen: {bedrag} EUR");
            }
        }

    }
}
