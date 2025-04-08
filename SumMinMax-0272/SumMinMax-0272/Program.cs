using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumMinMax_0272
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllText("input.txt").Split(' ');
            int[] arr =input.Select(int.Parse).ToArray();
            int result = SumMinMax(arr);
            File.WriteAllText("output.txt", result.ToString());
        }
        static int SumMinMax(int[] arr)
        {
           if(arr.Length == 0) return 0;
          
            int min = int.MaxValue;
            int max = int.MinValue;
            for(int i=0; i < arr.Length; i++)
            {
                if ((i+1) % 2 != 0)
                {
                    if (arr[i] < min)
                    {
                        min = arr[i];
                    }
                }
                else
                {
                    if (arr[i] > max)
                    {
                        max = arr[i];
                    }
                }
            }
           
            return max + min;
        }

       
    }
}
