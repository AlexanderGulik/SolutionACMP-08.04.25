using System;
using System.IO;

namespace OptBuy_0520
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText("input.txt");
            int n = int.Parse(input);
            int boxPrice = 114000;       
            int bundlePrice = 10250;      
            int pairPrice = 1050;        
            int boxPairs = 12 * 12;       
            int bundlePairs = 12;      

            int boxes = n / boxPairs;
            int remainingPairs = n % boxPairs;

            int bundles = remainingPairs / bundlePairs;
            remainingPairs = remainingPairs % bundlePairs;

          
            if (remainingPairs * pairPrice > bundlePrice) 
            {
                bundles++;
                remainingPairs = 0;
            }

        
            int currentCost = bundles * bundlePrice + remainingPairs * pairPrice;
            if (currentCost > boxPrice)
            {
                boxes++;
                bundles = 0;
                remainingPairs = 0;
            }

            File.WriteAllText("output.txt", $"{boxes} {bundles} {remainingPairs}");
        }
    }
}