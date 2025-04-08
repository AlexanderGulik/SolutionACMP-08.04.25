using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PussyNum_0689
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("input.txt");
            int n = int.Parse(input[0]);
            List<string> output = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(input[i].Trim());
                int bestBase = 0;
                int bestComplexity = int.MaxValue;
                string bestRepres = "";
                for (int b = 2; b <= 36; b++)
                {
                    string repres = ConvertToBase(number, b);
                    int complexity = repres.Length + CountDistinct(repres);
                    if (complexity < bestComplexity)
                    {
                        bestComplexity = complexity;
                        bestBase = b;
                        bestRepres = repres;
                    }
                   
                }

                output.Add($"{bestBase} {bestRepres}");
            }

            File.WriteAllLines("output.txt", output);
        }
            static  int CountDistinct(string s)
            {
            HashSet<char> result = new HashSet<char>();
            foreach (char c in s) { result.Add(c); }
            return result.Count;

            }
            static string ConvertToBase(int number, int b) 
            {
                if (number == 0) return "0";
                const string digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                StringBuilder sb = new StringBuilder();
                int n = number;
            while (n > 0) 
            {
                int remainder = n % b;
                sb.Insert(0, digits[remainder]);
                n /= b;
            
            }
            return sb.ToString();

            }
        }
    
}
