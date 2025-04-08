using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gods_0093
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("input.txt");
            int n = int.Parse(input[0]);
            string[] gods = new string[n];
            for (int i = 0; i < n; i++) 
            {
                gods[i] = input[i+1];
            
            }
            int m = int.Parse(input[n+1]);
            string[] lowGods = new string[m];
            for(int i = 0;i < m; i++)
            {
                lowGods[i] = input[n+2+i];
            }
            int[] result= new int[n];
            for(int i = 0;i<n; i++)
            {
                result[i]=countSimillarWords(gods[i],lowGods);
            }
            File.WriteAllText("output.txt", string.Join(" ", result));

        }
        static int countSimillarWords(string god, string[] lowGod)
        {
            int count = 0;
            foreach (string word in lowGod) 
            {
                if (IsTrueDifferent(god, word))
                {
                    count++;
                }
            
            }
            return count;

        }
        static bool IsTrueDifferent(string s1, string s2)
        {
            if(s1.Length != s2.Length)
            {
                return false;
            }
            int differences = 0;
            for (int i = 0; i < s1.Length; i++) 
            {
                if (s1[i] != s2[i])
                {
                    differences++;
                    if(differences > 1)
                    {
                        return false;
                    }
                }
            
            }
            return differences == 1;

        }
    }
}
