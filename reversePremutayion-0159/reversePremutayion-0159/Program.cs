using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reversePremutayion_0159
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("input.txt");
           int n = int.Parse(input[0]);
            int[] arr1 = Array.ConvertAll(input[1].Split(), int.Parse);
           
            int[] result = new int[n];
            for (int i = 0; i < n; i++) 
            {
                result[arr1[i] - 1] = i + 1;

            }
            File.WriteAllText("output.txt", string.Join(" ", result));


        }
    }
}
