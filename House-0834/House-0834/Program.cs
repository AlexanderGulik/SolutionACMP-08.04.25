using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace House_0834
{
   class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("input.txt");
            string[] linesOne = input[0].Split();
            string[] linesSecond = input[1].Split();

            double xk = double.Parse(linesOne[0], CultureInfo.InvariantCulture);
            double yk = double.Parse(linesOne[1], CultureInfo.InvariantCulture);

            double xc = double.Parse(linesSecond[0], CultureInfo.InvariantCulture);
            double yc = double.Parse(linesSecond[1], CultureInfo.InvariantCulture);
            double rc = double.Parse(linesSecond[2], CultureInfo.InvariantCulture);

            double distace = Math.Sqrt(Math.Pow(xk - xc, 2) + Math.Pow(yk - yc, 2));
            double area;
            if (distace <= rc)
            {
                area = Math.PI * rc * rc;
            }
            else
            {
                double g = distace;
                double b = Math.Sqrt(g * g - rc * rc);
                double angle = Math.Asin(b/g)
                    ;
                double triangleArea = (angle / 2) * rc * rc * 2;
                double s1 = Math.PI * rc * rc;
                double s2 = b * rc;
                area = s1+s2-triangleArea;
            }
            File.WriteAllText("output.txt", area.ToString("F6",CultureInfo.InvariantCulture));
        
        }
    }
}
