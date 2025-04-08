using System;
using System.IO;

namespace ChessBoard_0265
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("input.txt");
            int n = int.Parse(lines[0].Trim());
            bool[,] removed = new bool[9, 9];
            for (int i = 1; i <= n; i++)
            {
                string[] token = lines[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int row = int.Parse(token[0]);
                int col = int.Parse(token[1]);
                removed[row, col] = true;

            }
            int perimeter = 0;
            for (int r = 1; r <= 8; r++)
            {
                for (int c = 1; c <= 8; c++)
                {
                    if (removed[r, c])
                    {
                        if (r == 1 || !removed[r - 1, c])
                            perimeter++;
                        if (r == 8 || !removed[r + 1, c])
                            perimeter++;
                        if (c == 1 || !removed[r, c - 1])
                            perimeter++;
                        if (c== 8 || !removed[r, c + 1])
                            perimeter++;
                    }

                }

            }
            File.WriteAllText("output.txt",perimeter.ToString());
        }
    }
}
