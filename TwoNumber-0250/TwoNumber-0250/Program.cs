using System.Collections.Generic;
using System.IO;

namespace TwoNumber_0250
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(File.ReadAllText("input.txt").Trim());
            int result = n;
            for (int i = 0; ; i++)
            {
                if (funct(n - i))
                {
                    result = n - i;
                    break;
                }
                if (funct(n + i))
                {
                    result = n + i;
                    break;
                }
            }
            File.WriteAllText("output.txt", result.ToString());

        }



        static bool funct(int n)
        {
            HashSet<int> s = new HashSet<int>();
            while (n > 0)
            {
                s.Add(n % 10);
                n /= 10;
            }
            return s.Count <= 2;
        }



    }
}
