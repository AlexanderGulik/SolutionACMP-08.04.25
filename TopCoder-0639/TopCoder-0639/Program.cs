using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Runtime.InteropServices;

namespace TopCoder_0639
{
    internal class Program
    {
        static void Main(string[] args)
        {//1
            string[] input = File.ReadAllLines("input.txt");
            int n = int.Parse(input[0]);
            List<(double score, string name)> parp = new List<(double score, string name)>();
            int indexLines = 1;
            for (int i = 0; i < n; i++) 
            {
            int room = int.Parse(input[indexLines]);
                indexLines++;
                for (int j = 0; j < room; j++)
                {
                    string[] trap = input[indexLines].Split(' ');
                    double score = double.Parse(trap[0], CultureInfo.InvariantCulture);
                    string name = trap[1];
                    parp.Add((score, name));
                    indexLines++;

                }
            }

            parp = parp.OrderByDescending(p => p.score).ToList();
            using(StreamWriter write = new StreamWriter("output.txt"))
            {
                write.WriteLine(parp.Count);
                foreach(var par in parp)
                {
                    write.WriteLine($"{par.score.ToString("F2", CultureInfo.InvariantCulture)} {par.name}");
                }

            }

        }
    }
}
