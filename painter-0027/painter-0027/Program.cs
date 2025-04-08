using System.IO;

namespace painter_0027
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("input.txt");
            string[] firstLine = input[0].Split();
            int w = int.Parse(firstLine[0]);
            int h = int.Parse(firstLine[1]);
            int n = int.Parse(input[1].Trim());
            bool[,] painted = new bool[h, w];
            for (int i = 0; i < n; i++)
            {
                string[] rect = input[2 + i].Split();
                int x1 = int.Parse(rect[0]);
                int y1 = int.Parse(rect[1]);
                int x2 = int.Parse(rect[2]);
                int y2 = int.Parse(rect[3]);

                for (int y = y1; y < y2; y++)
                {
                    for (int x = x1; x < x2; x++)
                    {
                        painted[y, x] = true;
                    }

                }
            }
            int unpainted = 0;
            for(int y = 0; y < h; y++)
            {
                for (int x = 0; x < w; x++)
                {
                    if(!painted[y, x]) unpainted++;
                }
            }
            File.WriteAllText("output.txt", unpainted.ToString());

        }
    }
}
