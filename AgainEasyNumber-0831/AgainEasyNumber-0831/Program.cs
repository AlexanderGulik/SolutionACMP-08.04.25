using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgainEasyNumber_0831
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllText("input.txt").Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int maxSUm = -1;
            int result = -1;
            for (int num = Math.Max(a, 2); num <= b; num++) 
            {
                if (IsPrime(num)) { 
                int sum = DigitSum(num);
                    if (sum > maxSUm || (sum == maxSUm && num > result)) {
                    maxSUm = sum;
                        result = num;
                    }
                }
            
            }
            File.WriteAllText("output.txt", result.ToString());

        }
        static bool IsPrime(int num) 
        {
            if (num <= 1) return false;
            if (num == 2) return true;
            if (num%2==0) return false;
            int sqrt = (int)Math.Sqrt(num);
            for (int i = 3; i <= sqrt; i += 2) 
            {
                if (num % i == 0) 
                    return false;
            }
            return true;

        }
        static int DigitSum(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }
    }
}
