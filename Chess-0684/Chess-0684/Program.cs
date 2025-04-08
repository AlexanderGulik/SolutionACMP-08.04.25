using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_0684
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string start = input[0];
            string end = input[1];

            int startX = start[0] - 'a' + 1;
            int startY = start[1] - '0';
            int endX = end[0] - 'a' + 1;
            int endY = end[1] - '0';

            if ((startX + startY) % 2 != (endX + endY) % 2)
            {
                Console.WriteLine("NO");
                return;
            }
            if (endY <= startY)
            {
                Console.WriteLine("NO");
                return;
            }
            if((endY-startY)>=Math.Abs(endX-startX))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
