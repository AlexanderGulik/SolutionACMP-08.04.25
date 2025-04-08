using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_0009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("input.txt");
         
            string[] mas = input[1].Split(' ');
            int[] arr = mas.Select(int.Parse).ToArray();
            int positiveSum = positiveNumAddition(arr);
            int MinMAxSum = MinMAxAddition(arr);
            string result = $"{positiveSum} {MinMAxSum}";
            File.WriteAllText("output.txt", result);
        }
        static int positiveNumAddition(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > 0)
                {
                    sum+= arr[i];
                }
            } 
            return sum;
        }
        static int MinMAxAddition(int[] arr) 
        {
            int maxValue = arr.Max();
            int minValue = arr.Min();

            int maxIndex = Array.FindIndex(arr, x => x == maxValue);
            int minIndex = Array.FindIndex(arr, x => x == minValue);
            int start = Math.Min(maxIndex, minIndex);
            int end = Math.Max(maxIndex, minIndex);

            int result = 1;
            Console.WriteLine(maxIndex);
            Console.WriteLine(minIndex);
            for (int i = start+1; i < end; i++) 
            {
             result*=arr[i];
            }
            return result;
        
        
        }
       

    }
}
