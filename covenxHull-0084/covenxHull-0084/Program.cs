using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace covenxHull_0084
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("input.txt");
            string[] dimensions = lines[0].Split(' ');
            int n = int.Parse(dimensions[0]);
            int m = int.Parse(dimensions[1]);
            int leftz = -1, rightz = -1, upz = -1, downz = -1, p = -1;
            string[] matrix = new string[n];
            for (int z = 0; z < n; z++)
            {
                matrix[z] = lines[z + 1];
                string row = matrix[z];
                while (row.Contains('*'))
                {
                    p = row.IndexOf('*');
                    if (leftz == -1) leftz = p;
                    else if (leftz > p) leftz = p;

                    if (rightz == -1) rightz = p;
                    else if (rightz < p) rightz = p;

                    if (upz == -1) upz = z;
                    downz = z;

                    char[] rowArray = row.ToCharArray();
                    rowArray[p] = '.';
                    row = new string(rowArray);
                }
            }
            using (StreamWriter output = new StreamWriter("output.txt"))
            {
                for (int z = 0; z < n; z++)
                {
                    if (upz >= 0 && z < upz)
                    {
                        output.WriteLine(new string('.', m));
                    }
                    else if (p >= 0 && z >= upz && z <= downz)
                    {
                        output.Write(new string('.', leftz));
                        output.Write(new string('*', rightz - leftz + 1));
                        output.WriteLine(new string('.', m - rightz - 1));
                    }
                    else if (downz < n - 1 && z > downz)
                    {
                        output.WriteLine(new string('.', m));
                    }
                }
            }
        }

        
    }
}
