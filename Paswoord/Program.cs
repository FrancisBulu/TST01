using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;


namespace Paswoord
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            char[] ktrs = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            StringBuilder strb = new StringBuilder();
            string[] newStr = { PasswordGen(ktrs, strb, 5) };
            Console.WriteLine($"Uw gegenereerd paswoord is: {newStr[0]}");
            Console.WriteLine("Wilt u opnieuw uw paswoord generegen of het programma verlaten? \n(Als \"Ja\" druk op \"J\", als \"Neen\" druk op \"Enter\" of een andere character)");
            if (Console.ReadLine().ToUpper() == "J")
            {
                Console.Clear();
            }
            else
            {
                strb.Clear();
                Console.WriteLine($"Uw nieuw paswoord is: { PasswordGen(ktrs, strb, 5)}");
            }
        }
        static string PasswordGen(char[] ktrs, StringBuilder strb, int lengte)
        {
            for (int i = 0; i < lengte; i++)
            {
                strb.Append(ktrs[rnd.Next(ktrs.Length)]);
            }
            return strb.ToString();
        }
    }
}

