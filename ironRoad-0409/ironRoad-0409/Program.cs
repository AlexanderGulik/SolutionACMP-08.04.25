using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ironRoad_0409
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("input.txt");
            int n = int.Parse(input[0]);
            int[] point1 = Array.ConvertAll(input[1].Split(' '), int.Parse);

            double[] point2 = new double[n-1];
            for (int i = 0; i < n-1; i++) 
            {
                point2[i] = (point1[i]+point1[i+1])/2.0;

            }
            double result = point2.Average();
            



            File.WriteAllText("output.txt", result.ToString("F10",CultureInfo.InvariantCulture));
        }
    }
}
