using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
      
        int n = int.Parse(Console.ReadLine()); 
        int[] counties = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int m = int.Parse(Console.ReadLine()); 
        Dictionary<int, int> requests = new Dictionary<int, int>();
        for (int i = 0; i < m; i++)
        {
            var pair = Console.ReadLine().Split();
            int currentPriest = int.Parse(pair[0]);
            int desiredPriest = int.Parse(pair[1]);
            requests[currentPriest] = desiredPriest; 
        }

      
        Dictionary<int, int> mapping = new Dictionary<int, int>();
        foreach (var kvp in requests)
        {
            int currentPriest = kvp.Key;
            int desiredPriest = kvp.Value;
            if (!mapping.ContainsKey(currentPriest))
            {
                mapping[currentPriest] = desiredPriest;
            }
            else
            {
               
                int root = mapping[currentPriest];
                mapping[root] = desiredPriest;
                mapping[currentPriest] = desiredPriest;
            }
        }

      
        for (int i = 0; i < n; i++)
        {
            int priest = counties[i];
            if (mapping.ContainsKey(priest))
            {
                counties[i] = mapping[priest];
            }
        }

       
        Console.WriteLine(string.Join(" ", counties));
    }
}
