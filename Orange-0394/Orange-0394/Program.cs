using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orange_0394
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllText("input.txt").Split(' ');
            int n= int.Parse(input[0]);
            int m= int.Parse(input[1]);
            int d = SplitOrange(n, m);
            int result= n/d;
            File.WriteAllText("output.txt", result.ToString());
        }
        static int SplitOrange(int n, int m)
        {
            while (m != 0)
            {
                int temp = m;
                m = n % m;
                n=temp;
            }
            return n;

        }
    }
}
