using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterDecimal_0047
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(File.ReadAllText("input.txt").Trim());
            int bestD=FindBestD(input);
            File.WriteAllText("output.txt",bestD.ToString());
        }
        static int FindBestD(int n)
        {
            int bestD = 1;
            int bestSum = 1;
            for (int i = 1; i <= n; i++) 
            {
                if (n % i == 0)
                {
                    int currentSum = SumOfDifits(i);
                    if (currentSum > bestSum || (currentSum == bestSum && i < bestD)) 
                    {
                        bestD = i;
                        bestSum = currentSum;
                    
                    }
                }
              
            
            }
            return bestD;

        }
        static int SumOfDifits(int num)
        {
            int sum = 0;
            while (num > 0) 
            {
                sum += num%10;
                num /= 10;
            
            }
            return sum;

        }
    }
}
