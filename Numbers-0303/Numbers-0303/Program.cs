using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_0303
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int maxSum = int.MinValue;
            for (int i = 0; i < input.Length; i++) 
            {
            string modifiedNumber = input.Remove(i, 1);
                int alternatingSum = CalculateAlternatingSum(modifiedNumber);
                if (alternatingSum > maxSum) 
                {
                maxSum = alternatingSum;
                }
            }
            Console.WriteLine(maxSum);
        }
        static int CalculateAlternatingSum(string number)
        {
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                int digit = int.Parse(number[i].ToString());
                if (i % 2 == 0)
                {
                    sum += digit;
                }
                else
                {
                    sum -= digit;
                }
            }
            return sum;
        }
    }
}
