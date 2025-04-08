using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberNoIdentical_0670
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(File.ReadAllText("input.txt"));
            int result = findUniqueNumber(n);   
            File.WriteAllText("output.txt", result.ToString());

        }
        static int findUniqueNumber(int n)
        {
            int count = 0;
            int number = 1;
            while (true)
            {
                if (isUniqueDigts(number))
                {
                    count++;
                    if(count == n)
                    {
                        return number;
                    }
                }
                number++;

            }
        }
        static bool isUniqueDigts(int number)
        {
            string digits = number.ToString();
            return digits.Length==digits.Distinct().Count();
        }

    }
}
