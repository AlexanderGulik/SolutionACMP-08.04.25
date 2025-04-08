using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace easySort_0967
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("input.txt");
            string[] firstLine = input[0].Split();
            int n = int.Parse(firstLine[0]);
            int k1 = int.Parse(firstLine[1]);
            int k2 = int.Parse(firstLine[2]);
            int[] a = Array.ConvertAll(input[1].Split(), int.Parse).ToArray();
            int[] b = new int[n];
            for (int i = 0; i < n; i++)
            {
                int sk1 = sum(a[i], k1);
                int sk2 = sum(a[i], k2);
                b[i] = sk1 * sk2;
            }
            Array.Sort(b);
            File.WriteAllText("output.txt", string.Join(" ", b));

        }
        static int sum(int number, int basek)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % basek;
                number /= basek;
            }
            return sum;
        }
    }
}
