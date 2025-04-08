using System;
using System.IO;

namespace easyCalculation_0059
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllText("input.txt").Split(' ');
            long n = long.Parse(input[0]);
            int k = int.Parse(input[1]);


            string result = ConvertToBase(n, k);
            long sum1 = 1;
            long sum2 = 0;

            foreach (char c in result)
            {
                int digit = c - '0'; 
                sum1 *= digit;
                sum2 += digit;
            }

            long q = sum1 - sum2;
            File.WriteAllText("output.txt", q.ToString());
        }

        static string ConvertToBase(long number, int baseValue)
        {
            if (number == 0) return "0";
            string result = "";
            while (number > 0)
            {
                result = (number % baseValue) + result;
                number /= baseValue;
            }
            return result;
        }
    }
}
