using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aftomorfDigit_0785
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllText("input.txt").Split(' ');
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            string result = FindAutomorph(a, b);
            File.WriteAllText("output.txt", result);

        }
        static string FindAutomorph(int a, int b)
        {
            StringBuilder result = new StringBuilder();
            for(int i =a; i <= b; i++)
            {
                if (isAutomorph(i))
                {
                    result.Append(i).Append(" ");
                }
            }
            return result.ToString().Trim();
        }
       
        static bool isAutomorph(int n)
        {
            long square = (long)n*n;
            int digits= getdigit(n);
            long mod = (long)Math.Pow(10, digits);
            return square%mod == n;
        }
        static int getdigit(int n) 
        {
            if (n == 0) return 1;
            int count = 0;
            while (n != 0)
            {
                n /= 10;
                count++;
            }
            return count;
        
        }
        
    }
}
