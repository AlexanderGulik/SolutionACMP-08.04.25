using System;
using System.Collections.Generic;

namespace DifferentDigits
{
    class Program
    {
        
        static bool HasUniqueDigits(int n, int z)
        {
            string digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            HashSet<char> uniqueDigits = new HashSet<char>();
            string converted = "";

            while (n > 0)
            {
                char sym = digits[n % z];
                n /= z; 
                uniqueDigits.Add(sym);
                converted += sym; 
            }

           
            return uniqueDigits.Count == converted.Length;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int z = 2; z < 37; z++)
            {
                if (HasUniqueDigits(n, z))
                {
                    Console.Write(z + " "); 
                }
            }
        }
    }
}
