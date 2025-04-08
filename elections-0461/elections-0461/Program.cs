using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elections_0461
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("input.txt");
            int k = int.Parse(input[0]);
            int[] part= Array.ConvertAll(input[1].Split(' '), int.Parse).ToArray();
            Array.Sort(part);
            int result = minVote(part);
            File.WriteAllText("output.txt", result.ToString());

        }
        static int minVote(int[] part) 
        {
            int result = 0;
            int halfPart = 1+part.Length / 2;
            for (int i=0; i < halfPart; i++)
            {
                int count=part[i];
                
                result += (count/2)+1;

            }
            return result;
        
        }
    }
}
