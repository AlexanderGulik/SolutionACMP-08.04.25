using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace swap_0693
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText("input.txt").Trim();
            string[] words = input.Split(' ');
            string first = words[0].ToLower();
            string second = words[1].ToLower();

            char[] firstArr = first.ToCharArray();
            char[] secondArr = second.ToCharArray();

            Array.Sort(firstArr);
            Array.Sort(secondArr);

            string result = firstArr.SequenceEqual(secondArr) ? "Yes" : "No";
            File.WriteAllText("output.txt", result);

        }
    }
}
