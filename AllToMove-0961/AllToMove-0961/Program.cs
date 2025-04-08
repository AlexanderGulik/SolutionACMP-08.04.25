using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllToMove_0961
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sizes = Console.ReadLine().Split();
            int n = int.Parse(sizes[0]);
            int m = int.Parse(sizes[1]);

            char[,] filedT = new char[n, m];
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine();
                for (int j = 0; j < m; j++)

                {
                    filedT[i, j] = line[j];
                }
            }
            Console.ReadLine();
            char[,] filedT1=new char[n, m];
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine();
                for (int j = 0; j < m; j++)

                {
                    filedT1[i, j] = line[j];
                }
            }
            HashSet<char> movingObjects = new HashSet<char>();
            for (int i = 0; i < n; i++) 
            {
                for (int j = 0; j < m; j++) 
                {
                char obj = filedT1[i, j];
                    if (obj != '.' && filedT1[i, j] != obj) { movingObjects.Add(obj); }
                }
            }
            var result = movingObjects.OrderBy(c=>char.IsUpper(c)).ThenBy(c=>c).ToList();
            Console.WriteLine(result.Count);
            Console.WriteLine(string.Join("",result));

        }
    }
}
