using System;
using System.Collections.Generic;
using System.IO;

namespace ModuleSum_0579
{
    class Program
    {
        static void Main()
        {
            string[] input = File.ReadAllLines("input.txt");
            int n = int.Parse(input[0]);
            string[] lines = input[1].Split();
            List<int> a = new List<int>();
            List<int> b = new List<int>();
            int s = 0, s1 = 0;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(lines[i]);
                if (number >= 0)
                {
                    b.Add(i + 1);
                    s += number;
                }
                else
                {
                    a.Add(i + 1);
                    s1 += number;
                }
            }
            using (StreamWriter output = new StreamWriter("output.txt"))
            {
                if (Math.Abs(s1) > Math.Abs(s))
                {
                    output.WriteLine(a.Count);
                    output.WriteLine(string.Join(" ", a));

                }
                else 
                {
                    output.WriteLine(b.Count);
                    output.WriteLine(string.Join(" ", b));
                }
            }

        }
    }
}