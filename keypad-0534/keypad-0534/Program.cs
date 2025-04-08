using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace keypad_0534
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("input.txt");
            string linesFirst = lines[0].Trim();
            string linesSecond = lines[1];
            string linesThird = lines[2];
            string linesFrothd = lines[3];

                int n = int.Parse(linesFirst);
            int[] terp = Array.ConvertAll(linesSecond.Split(),int.Parse).ToArray();
            int k = int.Parse(linesThird);
            int[] posled= Array.ConvertAll(linesFrothd.Split(), int.Parse).ToArray();
            string[] result= new string[n];
            for (int i = 0; i < k; i++) 
            {
                terp[posled[i]-1] -= 1;
                
            }

            for (int j = 0; j < n; j++)
            {
                if (terp[j] >= 0)
                {
                    result[j] = "no";
                }
                else
                {
                    result[j] = "yes";

                }

            }
            File.WriteAllText("output.txt", string.Join("\n",result));


        }
    }
}
