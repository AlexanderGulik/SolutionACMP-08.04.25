using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;
namespace trap_0515
{
    internal class Program
    {
        static void Main(string[] args)
        {//1
         
            string[] input = File.ReadAllLines("input.txt");

            int n= int.Parse(input[0]);
            int[,] traps = new int[n,2];
            for (int i = 0; i < n; i++) 
            {
                string[] cord = input[i+1].Split();
                traps[i,0]=int.Parse(cord[0]);
                traps[i,1]=int.Parse(cord[1]);
            }
            double total = 0;
            int x=0,y=0;
            for (int i = 0; i < n; i++) 
            {
            int cx = traps[i,0];
            int cy = traps[i,1];
                total += calute(x, y, cx, cy);
                x = cx; y = cy;
            
            }
            total += calute(x, y,0,0);
            File.WriteAllText("output.txt", total.ToString("F3", CultureInfo.InvariantCulture));
        }
        static double calute(int x1, int y1, int x2, int y2) 
        {
        return Math.Sqrt((x2-x1)*(x2 - x1)+(y2-y1)*(y2 - y1));
        }
    }
}
