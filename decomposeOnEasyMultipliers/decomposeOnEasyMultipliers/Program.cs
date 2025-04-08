using System;
using System.Collections.Generic;
using System.IO;

namespace decomposeOnEasyMultipliers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText("input.txt");
            long n = int.Parse(input);
            bool first = true;
            for (long i = 2; i <= n; i++)
            {
                if (i * i > n) i = n;
                while (n % i == 0)
                {
                    if (first)
                    {
                        Console.Write(i);
                        first = false;
                    }
                    else
                    {
                        Console.Write("*" + i);
                       
                    }
                    n /= i;

                }
            }


            
        }
        

    }
}
