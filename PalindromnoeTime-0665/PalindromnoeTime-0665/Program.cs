using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace PalindromnoeTime_0665
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText("input.txt").Trim();
            string[] time = input.Split(':');
            int hours = int.Parse(time[0]);
            int min = int.Parse(time[1]);
            while (true)
            {
                min++;
                if (min == 60)
                {
                    min = 0;
                    hours++;
                    if (hours == 24)
                    {
                        hours = 0;
                    }
                }
                string hh = hours.ToString("D2");
                string mm = min.ToString("D2");
                if (hh[0] == mm[1] && hh[1] == mm[0])
                {
                    string result = $"{hh}:{mm}";
                    File.WriteAllText("output.txt", result);
                    break;
                }

            }

        }
    }
}
