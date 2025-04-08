using System;
using System.IO;

namespace BussTwo_0667
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllText("input.txt").Split();
            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);
            int K = int.Parse(input[2]);
            int result = FindMinBuses(N, M, K);
            File.WriteAllText("output.txt", result.ToString());
        }

        static int FindMinBuses(int N, int M, int K)
        {
            if (K <= 2) return 0; 

         
            int minBusesFromChildren = (N + (K - 2) - 1) / (K - 2); 
            int minBusesFromTotal = (N + M + K - 1) / K;
            int startBuses = Math.Max(minBusesFromChildren, minBusesFromTotal);

           
            for (int B = startBuses; B <= N + M; B++)
            {
             
                int busesWithChildren = (N + (K - 2) - 1) / (K - 2);
                busesWithChildren = Math.Min(busesWithChildren, B);

                if (M >= 2 * busesWithChildren && B * K >= N + M)
                    return B;
            }

            return 0; 
        }
    }
    }
