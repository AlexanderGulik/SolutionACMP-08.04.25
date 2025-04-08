using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beautifullyWall_0645
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //11 = 10x1
            // 1 1 1 1
            // 1 1 1 1
            // 1 1 1 1 // 3 4 мяу или не мяу? ответ: не мяу


            // 1 1 || 1 2

            // 1 1 1 1 1
            // 1 1 1 1 1
            // 1 1 1 1 1
            // 1 1 1 1 1 || 4 5

            //
            // 4x4 = 3
            int k = int.Parse(File.ReadAllText("input.txt"));
            int h=0, w=0, min;
            min = 2 * k;
            for (int i = 1; i <= k; i++)
            {
                int j = k / i;
                if (fn(i, j, k) < min)
                {
                    min = fn(i, j, k);
                    h = i;
                    w = j;
                }
            }

            
            File.WriteAllText("output.txt", $"{h} {w}");
        }
        static int fn(int h, int w, int k) 
        {
            return Math.Abs(h - w) + k - h * w;


        }
    }
}
