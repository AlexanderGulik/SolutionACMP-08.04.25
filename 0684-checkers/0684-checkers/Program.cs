using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0684_checkers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllText("input.txt").Split();
            string start = input[0];
            string end = input[1];
            int startCol = start[0] - 'a' + 1;
            int startRow=start[1]-'0';
            int endCol = end[0] - 'a' + 1;
            int endRow=end[1]-'0';

            if ((startCol + startRow) % 2 != (endCol + endRow) % 2)
            {
                File.WriteAllText("output.txt", "NO");
                return;
            }
            if (endRow <= startRow)
            {
                File.WriteAllText("output.txt", "NO");
                return;
            }
            if(Math.Abs(endRow - startRow) == endRow - startRow)
            {
                File.WriteAllText("output.txt", "YES");
            }
            else
            {
                File.WriteAllText("output.txt", "NO");
            }
        }
    }
}
