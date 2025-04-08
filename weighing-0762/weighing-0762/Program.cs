using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weighing_0762
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText("input.txt");
            int n = int.Parse(input);
            int result = weighingMonet(n);
            File.WriteAllText("output.txt", result.ToString());
        }
        static int weighingMonet(int n)
        {
            if (n <= 3) return 1;
            int k = 0;
            int current = 1; 

            while (current < n)
            {
                current *= 3;
                k++;
            }
            return k;
        }
    }
}
