using System;
using System.IO;
using System.Linq;

namespace friendNumber_0274
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("input.txt");
            int n = int.Parse(lines[0]);
            string[] results = new string[n];
            for (int i = 0; i < n; i++)
            {
                string[] test = lines[i + 1].Split();
                string a = test[0];
                string b = test[1];
                if (friend(a, b))
                {
                    results[i] = "YES";
                }
                else
                {
                    results[i] = "NO";
                }
            }
            File.WriteAllLines("output.txt", results);
        }

        static bool friend(string a, string b)
        {
        
            var setA = a.ToCharArray().Distinct().OrderBy(c => c);
            var setB = b.ToCharArray().Distinct().OrderBy(c => c);

          
            return setA.SequenceEqual(setB);
        }

    }
}
