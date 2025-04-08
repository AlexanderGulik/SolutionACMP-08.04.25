using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceHemming
{
    internal class Program
    {
        static int HAmmingDistance(string a, string b)
        {
            int distance = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                {
                    distance++;
                }
            }
            return distance;
        }
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("input.txt");
            string s = input[0];
            int n= int.Parse(input[1]);
            List<string> message = new List<string>();
            for (int i = 2; i < 2 + n; i++) 
            {
            message.Add(input[i]);
            }
            int minDistance = int.MaxValue;
            List<int> bestIndices = new List<int>();
            for (int i = 0; i < message.Count; i++) 
            {
            int distance = HAmmingDistance(s, message[i]);
                if (distance < minDistance) 
                {
                minDistance = distance;
                    bestIndices.Clear();
                    bestIndices.Add(i+1);
                }
                else if (distance == minDistance)
                {
                    bestIndices.Add(i+1);
                }
            }
            bestIndices.Sort();
            using (StreamWriter output = new StreamWriter("output.txt")) 
            {
                output.WriteLine(bestIndices.Count);
                output.WriteLine(string.Join(" ", bestIndices));
            
            }
        }
    }
}
