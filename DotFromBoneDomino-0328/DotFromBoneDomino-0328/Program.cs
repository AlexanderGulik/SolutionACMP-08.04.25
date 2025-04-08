using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotFromBoneDomino_0328
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(File.ReadAllText("input.txt"));
            long totalPoints = caluleteTotal(n);
            File.WriteAllText("output.txt", totalPoints.ToString());
        }
        static long caluleteTotal(int n) 
        {
            long total = 0;
            for (int i = 0; i <= n; i++) 
            {
                for (int b = i; b <= n; b++) 
                {
                    total += i + b;
                }
            
            }
            return total;
        
        }
    }
}
