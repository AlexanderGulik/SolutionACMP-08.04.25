using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyColorRain_0125
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("input.txt");
            int n = int.Parse(lines[0].Trim());
            int[,] matrix = new int[n,n];
            for (int i = 0; i < n; i++) 
            {
                string[] token = lines[i + 1].Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < n; j++) 
                {
                    matrix[i, j]=int.Parse(token[j]);
                }
            
            }
            string colorsLine=lines[n+2].Trim();
            string[] colorToken = colorsLine.Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);
            int[] color = new int[n];
            for(int i = 0;i < n; i++)
            {
                color[i]=int.Parse(colorToken[i]);
            }
            int badBrigdes = 0;
            for(int i = 0; i < n; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    if(matrix[i,j] == 1 && color[i] != color[j])
                    {
                        badBrigdes++;
                    }
                }
            }
            File.WriteAllText("output.txt", badBrigdes.ToString());
        }
    }
}
