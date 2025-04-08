using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gamble_0648
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("input.txt");
             int n = int.Parse(input[0]);
            int[] cards = input[1].Split(' ').Select(int.Parse).ToArray();
            int LengtCards = cards.Length/2;
            Array.Sort(cards);
            int shrek = 0;
            int don = 0;
            for (int i = 0; i < LengtCards; i++) 
            {
                don += cards[i];
               
            }
            for (int j = LengtCards; j < n; j++)
            {
                shrek += cards[j];
            }
            int result = shrek - don;
            File.WriteAllText("output.txt", result.ToString());
        }
    }
}
