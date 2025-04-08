using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NubmerAfterComma_0803
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllText("input.txt").Split(' ');
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int num = int.Parse(input[2]);
            if (a >= b)
                a %= b;
            for (int i = 0; i < num; i++) 
            {
                a = (a % b) * 10;
            }

            int result = a / b;
     
           
            File.WriteAllText("output.txt", result.ToString());

        }
        
    }
}
