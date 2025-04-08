using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagramma_0847
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllText("input.txt").Split();
            string WordOne = input[0];
            string WordTwo = input[1];
            bool isAnagram = AreAnagrams(WordOne, WordTwo);
            File.WriteAllText("output.txt", isAnagram ? "YES":"NO"); 
        }
        static bool AreAnagrams(string WordOne, string WordTwo)
        {
            if (WordOne == WordTwo) return false;
            if (WordOne.Length != WordTwo.Length) return false;

            bool hasSameLetterInSamePosition = false;
            for (int i = 0; i < WordOne.Length; i++)
            {
                if (WordOne[i] == WordTwo[i])
                {
                    hasSameLetterInSamePosition = true;
                    break;
                }
            }
            if (hasSameLetterInSamePosition) return false;
            var sortedOne = WordOne.OrderBy(c=>c).ToArray();
            var sortedTwo = WordTwo.OrderBy(c=>c).ToArray();
            
                return sortedOne.SequenceEqual(sortedTwo);
            
        }
    }
}
