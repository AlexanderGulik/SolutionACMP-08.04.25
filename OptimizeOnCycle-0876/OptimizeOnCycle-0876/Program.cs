using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace OptimizeOnCycle_0876
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllText("input.txt").Trim().Split(' ');
            double a = double.Parse(input[0], CultureInfo.InvariantCulture);
            double b = double.Parse(input[1], CultureInfo.InvariantCulture);
            double r = double.Parse(input[2], CultureInfo.InvariantCulture);

            string result = ComparerResult(a, b, r);
            File.WriteAllText("output.txt", result);
           
        }
        static string ComparerResult(double a, double b, double r)
        {
            string result = "";
           
            double norm = Math.Sqrt(a*a+b * b);
            double maxValue = r * norm;
            double x = (a * r) / norm;
            double y = (b * r) / norm;
       
            result = maxValue.ToString("F12", CultureInfo.InvariantCulture) + Environment.NewLine + x.ToString("F12", CultureInfo.InvariantCulture) + " " + y.ToString("F12", CultureInfo.InvariantCulture);
            return result;

        }
        
    }
}
