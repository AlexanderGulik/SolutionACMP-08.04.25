using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunnySequence_0996
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(File.ReadAllText("input.txt").Trim());
            int result = funnySequence(n);
            File.WriteAllText("output.txt", result.ToString());

        }
        static int funnySequence(int n)

        {
            int[] a = new int[n + 1];
            HashSet<int> seen = new HashSet<int>();
            a[1] = 1;
            seen.Add(1);
            for (int i = 2; i <= n; i++) 
            {
                if (seen.Contains(i))
                {
                    a[i] = a[i - 1] + 3;
                }
                else
                {
                    a[i] = a[i - 1] + 2;
                }
                seen.Add(a[i]);
               
            
            }
            return a[n];

        }
    }
}
