using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaaseiSpel
{
    class Program
    {
        static Random rdnEi = new Random();
        static void Main(string[] args)
        {
            char[,] tab = new char[10, 10];
            int entryX;
            int entryY;
            int eiX, eiY;
            bool klaar = false;
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    tab[i, j] = '.';
                }
            }
            eiX = rdnEi.Next(10);
            eiY = rdnEi.Next(10);
            while (!klaar)
            {
                TabEiren(tab);
                Console.WriteLine("Geef een rij tussen \"0 en 9\"");
                entryX = int.Parse(Console.ReadLine());
                Console.WriteLine("Geef een kolom tussen \"0 en 9\" ");
                entryY = int.Parse(Console.ReadLine());
                tab[entryX, entryY] = 'X';
                if (entryX == eiX && entryY == eiY)
                {
                    tab[eiX, eiY] = 'E';
                    Console.WriteLine("Jij hebt het ei gevonden! \nWil jij het programma verlaten? (druk op knop \"J\")");
                    if (Console.ReadLine().ToUpper() == "J")
                        klaar = true;
                    else
                    {
                        for (int i = 0; i < tab.GetLength(0); i++)
                        {
                            for (int j = 0; j < tab.GetLength(1); j++)
                            {
                                tab[i, j] = '0';
                            }
                        }
                        eiX = rdnEi.Next(10);
                        eiY = rdnEi.Next(10);
                    }
                }
                Console.Clear();
                if (eiX < entryX)
                    Console.WriteLine("Het ei ligt meer naar het noorden");
                else if (eiX > entryX)
                    Console.WriteLine("Het ei ligt meer naar het zuiden");
                else
                    Console.WriteLine($"De X-positie: \"{entryX}\" is juist");
                if (eiY < entryY)
                    Console.WriteLine("Het ei ligt meer naar het westen");
                else if (eiY > entryY)
                    Console.WriteLine("Het ei ligt meer naar het oosten");
                else
                    Console.WriteLine($"De Y-positie: \"{entryY}\" is juist");
            }
            Console.Clear();
            Console.WriteLine("Dank u voor het spel");
        }
        private static void TabEiren(char[,] tab)
        {
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    Console.Write($"  {tab[i, j]}  ");
                }
                Console.WriteLine();
            }
        }
    }
}
