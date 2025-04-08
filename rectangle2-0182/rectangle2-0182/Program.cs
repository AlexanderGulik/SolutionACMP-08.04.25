using System.IO;

namespace rectangle2_0182
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllText("input.txt").Split(' ');
            int x1 = int.Parse(input[0]);
            int y1 = int.Parse(input[1]);
            int x2 = int.Parse(input[2]);
            int y2 = int.Parse(input[3]);
            int x3 = int.Parse(input[4]);
            int y3 = int.Parse(input[5]);
            int x4=0, y4 = 0;
        

            if (((x2 - x1) * (x3 - x1) + (y2 - y1) * (y3 - y1)) == 0)
            {
                x4 = x1 + (x2 - x1) + (x3 - x1);
                y4 = y1 + (y2 - y1) + (y3 - y1);

            }
            else if (((x1 - x2) * (x3 - x2) + (y1 - y2) * (y3 - y2)) == 0)
            {
                x4 = x2 + (x1 - x2) + (x3 - x2);
                y4 = y2 + (y1 - y2) + (y3 - y2);
            }
            else if (((x1 - x3) * (x2 - x3) + (y1 - y3) * (y2 - y3)) == 0)
            {
                x4 = x3 + (x1 - x3) + (x2 - x3);
                y4 = y3 + (y1 - y3) + (y2 - y3);
            }

            File.WriteAllText("output.txt", $"{x4} {y4}");


        }
    }
}
