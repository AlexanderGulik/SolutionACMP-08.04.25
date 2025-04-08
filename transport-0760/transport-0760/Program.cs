using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace transport_0760
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            string[] input = File.ReadAllLines("input.txt");
            string[] firstLine = input[0].Split(' ');
            int n = int.Parse(firstLine[0]);
            int maxSpeed = int.Parse(firstLine[1]);
            int totalLength= int.Parse(firstLine[2]);

            double totalTime = totalLength / (double)maxSpeed * 60;
            if (n > 0) 
            {
                string[] secondLine = input[1].Split();
                for (int i = 0; i < n; i++) { 
                int position = int.Parse(secondLine[i*2]);
                int StopTime = int.Parse(secondLine[i*2+1]);
                    totalTime += StopTime;
                }
            }
            File.WriteAllText("output.txt", totalTime.ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}
