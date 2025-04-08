using System;
using System.IO;

namespace cricles_0841
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = int.Parse(File.ReadAllText("input.txt").Trim());
            double result = 0;
            if (n == 0) { result = 1; }
            else
            {
                result = Math.Pow(n, 2) - n + 2;

            }


            File.WriteAllText("output.txt", result.ToString());
        }
    }
}
