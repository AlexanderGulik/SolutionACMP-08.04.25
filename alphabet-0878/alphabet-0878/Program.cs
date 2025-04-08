using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alphabet_0878
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText("input.txt").Trim();
            int n = 26;
            char[] knows = input.ToCharArray();
            int[] order = new int[n];
            var sortC = Enumerable.Range(1, n).OrderBy(i => knows[i-1]).ToList();
            for (int i = 0; i < n; i++) 
            {
                if (knows[sortC[i] - 1] < 'A' +i)
                {
                    File.WriteAllText("output.txt", "NO");
                return;
                }
                order[i] = sortC[i];
            
            }

            using(StreamWriter write = new StreamWriter("output.txt"))
            {
                write.WriteLine("YES");
                write.WriteLine(string.Join(" ", order));
            }
        }
    }
}
