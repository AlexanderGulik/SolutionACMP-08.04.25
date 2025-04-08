using System;
using System.IO;

namespace kasting_0925
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("INPUT.TXT");
            int tipe = int.Parse(input[0]);
            int[] m = Array.ConvertAll(input[1].Split(' '), int.Parse);
            int n = m[0];
            int a = m[1];
            int b = m[2];
            int c = m[3];

            int result = 0;

            if (tipe == 1)
            {

                result = Math.Max(0, a + b + c - 2 * n);
            }
            else if (tipe == 2)
            {

                result = Math.Min(a, Math.Min(b, c));
            }

            File.WriteAllText("OUTPUT.TXT", result.ToString());
        }
    }
}