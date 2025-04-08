using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunter_0764
{
    internal class Program
    {
        static int Gcd(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a=temp;
            }
            return a;
        }
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("input.txt");
            int n = int.Parse(lines[0]);

            Dictionary<string, int> dorectionCount = new Dictionary<string, int>();
            for(int i =1; i <= n; i++)
            {
                string[] parts = lines[i].Split();
                int x = int.Parse(parts[0]);
                int y = int.Parse(parts[1]);

                int gcd = Gcd(Math.Abs(x), Math.Abs(y));
                int nx =x/gcd;
                int ny= y/gcd;

                if (n < 0 || (nx == 0 && ny < 0))
                {
                    nx = -nx;
                    ny = -ny;
                }
                string key = $"{nx}m {ny}";
                if(dorectionCount.ContainsKey(key))
                    dorectionCount[key]++;
                else dorectionCount[key] = 1;
            }
            int maxCount = 0;
            foreach (var count in dorectionCount.Values)

            {
                if (count > maxCount) {
                    maxCount = count;
                }
                
            }
            File.WriteAllText("output.txt", maxCount.ToString());

        }
    }
}
