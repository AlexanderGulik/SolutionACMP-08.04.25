using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace annagramm_0574
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("input.txt");
            string s1= input[0];
            string s2= input[1];
            string result = areAnagrams(s1, s2)?"YES":"NO";
            File.WriteAllText("output.txt", result);


        }
        static bool areAnagrams(string s1, string s2)
        {
            if (s1.Length != s2.Length)
            {
                return false;
            }
            int[] count = new int[26];
            foreach (char c in s1)
            {
                count[c - 'A']++;

            }
            foreach (char c in s2)
            {
                count[c - 'A']--;

            }
            foreach (int ferq in count)
            {
                if (ferq != 0)
                {
                    return false;
                }
            }
            return true;
        }


    }
}
