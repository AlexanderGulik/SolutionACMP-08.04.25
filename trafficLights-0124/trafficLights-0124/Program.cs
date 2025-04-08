using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trafficLights_0124
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("input.txt");
            int[] firstLine = input[0].Split().Select(int.Parse).ToArray();
            int n = firstLine[0];
            int m = firstLine[1];

            int[] trafficLights = new int[n+1];
            for (int k = 1; k <= m; k++) 
            {
                int[] tunnel = input[k].Split().Select(int.Parse).ToArray();
                int i = tunnel[0];
                int j = tunnel[1];

                trafficLights[i]++;
                trafficLights[j]++;
            
            
            }
            string result = string.Join(" ", trafficLights.Skip(1));

            File.WriteAllText("output.txt", result);

        }
    }
}
