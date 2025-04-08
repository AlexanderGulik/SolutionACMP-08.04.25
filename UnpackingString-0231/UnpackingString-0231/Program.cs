using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnpackingString_0231
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText("input.txt").Trim();
            string unpaked = Unpack(input);

            string result = SplitIntoLines(unpaked, 40);
            File.WriteAllText("output.txt", result);

        }
       static string Unpack(string input)
        {
            StringBuilder result = new StringBuilder();
            int i = 0;
            while (i < input.Length)
            {
                if (char.IsDigit(input[i]))
                {
                    int numStart = i;
                    while (i <input.Length && char.IsDigit(input[i]))
                    {
                        i++;
                    }
                    int count = int.Parse(input.Substring(numStart,i-numStart));
                    char symbol = input[i];
                    result.Append(symbol, count);
                    i++;
                }
                else
                {
                    result.Append(input[i]);
                    i++;
                }
              
            }
            return result.ToString();
        }

        static string SplitIntoLines(string input, int lineLength)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < input.Length; i += lineLength)
            {
                int length = Math.Min(lineLength, input.Length - i);
                result.AppendLine(input.Substring(i, length));


            }
            return result.ToString();
        }

    }
}
