using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Professor_0287
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("input.txt");
            string[] firstLine = input[0].Split();
            int n = int.Parse(firstLine[0]);
            int m = int.Parse(firstLine[1]);
            string lecture = input[1];
            HashSet<string> set = new HashSet<string>();
            for (int i = 0; i <= n - m; i++)
            { 
            string substring = lecture.Substring(i,m);
                set.Add(substring);
            }
            File.WriteAllText("output.txt", set.Count.ToString());
        }
    }
}
