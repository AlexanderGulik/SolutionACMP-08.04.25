using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nCycle_0069
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inpput = File.ReadAllText("input.txt").Split();
            int n = int.Parse(inpput[0]);
            int a = int.Parse(inpput[1]);
            double thete = Math.PI / (2 * n);
            double tanValue = Math.Tan(thete);
            double difference = (a / 2.0) * tanValue;

            string result = (difference < 1) ? "YES" : "NO";
            File.WriteAllText("output.txt", result);
        }
    }
}
