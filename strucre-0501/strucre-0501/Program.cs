using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strucre_0501
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("input.txt");
            int n = int.Parse(input[0]);
            int[][] privatePlots = new int[n][];
            for (int i = 0; i < n; i++)
            {
                privatePlots[i] = input[i + 1].Split().Select(int.Parse).ToArray();
                privatePlots[i] = normalize(privatePlots[i]);

            }
            int[] constructionPlot = input[n + 1].Split().Select(int.Parse).ToArray();
            constructionPlot = normalize(constructionPlot);
            int totalArea = 0;
            foreach (var plot in privatePlots)
            {
                int intersectionArea = GerInter(plot, constructionPlot);
                totalArea += intersectionArea;

            }
            File.WriteAllText("output.txt", totalArea.ToString());


        }
        static int[] normalize(int[] rect)
        {
            int x1 = Math.Min(rect[0], rect[2]);
            int y1 = Math.Min(rect[1], rect[3]);
            int x2 = Math.Max(rect[0], rect[2]);
            int y2 = Math.Max(rect[1], rect[3]);
            return new int[] { x1, y1, x2, y2 };
        }
        static int GerInter(int[] rect1, int[] rect2)
        {
            int x1 = Math.Max(rect1[0], rect2[0]);
            int y1 = Math.Max(rect1[1], rect2[1]);
            int x2 = Math.Min(rect1[2], rect2[2]);
            int y2 = Math.Min(rect1[3], rect2[3]);
            if (x1 < x2 && y1 < y2)
            {
                return (x2 - x1) * (y2 - y1);
            }
            return 0;

        }
    }
}
