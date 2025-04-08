using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace runeWord_0283
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText("input.txt").Trim();
            bool res = inRunicWord(input);
            File.WriteAllText("output.txt", res ? "Yes" : "No");

        }
        static bool inRunicWord(string word)
        {
            int i = 0;
            while (i < word.Length)
            {
                if (i >= word.Length || !char.IsUpper(word[i]))
                {
                    return false;

                }
                int runeLength = 1;
                while (runeLength < 4 && i + runeLength < word.Length && char.IsLower(word[i + runeLength]))
                    {
                    runeLength++;
                }
                if (runeLength > 4 || runeLength < 2)
                {
                    return false;
                }
                i+=runeLength;


            } 
            return true; 
        
        
        }
    }
}
