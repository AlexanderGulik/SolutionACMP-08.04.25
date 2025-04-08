using System;
using System.IO;

namespace testIQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllText("input.txt").Split();
            string n1 = input[0];
            string n2 = input[1];
            string res = stringSum(n1, n2);
            File.WriteAllText("output.txt", res);
        }

        static string stringSum(string n1, string n2)
        {

            string[] p1 = n1.Split('.');
            string[] p2 = n2.Split('.');

            string intPart1 = p1[0];
            string intPart2 = p2[0];

            string fracPart1 = p1.Length > 1 ? p1[1] : "0";
            string fracPart2 = p2.Length > 1 ? p2[1] : "0";


            int maxFracLength = Math.Max(fracPart1.Length, fracPart2.Length);
            fracPart1 = fracPart1.PadRight(maxFracLength, '0');
            fracPart2 = fracPart2.PadRight(maxFracLength, '0');


            string fracSum = SumStrings(fracPart1, fracPart2);


            bool carry = false;
            if (fracSum.Length > maxFracLength)
            {
                carry = true;
                fracSum = fracSum.Substring(1);
            }


            string intSum = SumStrings(intPart1, intPart2);


            if (carry)
            {
                intSum = SumStrings(intSum, "1");
            }


            fracSum = fracSum.TrimEnd('0');


            return fracSum.Length > 0 ? $"{intSum}.{fracSum}" : intSum;
        }

        static string SumStrings(string n1, string n2)
        {
            char[] num1 = n1.ToCharArray();
            char[] num2 = n2.ToCharArray();
            Array.Reverse(num1);
            Array.Reverse(num2);

            int carry = 0;
            string result = "";
            int maxLength = Math.Max(n1.Length, n2.Length);

            for (int i = 0; i < maxLength; i++)
            {
                int digit1 = (i < num1.Length) ? num1[i] - '0' : 0;
                int digit2 = (i < num2.Length) ? num2[i] - '0' : 0;
                int sum = digit1 + digit2 + carry;
                carry = sum / 10;
                result += (sum % 10).ToString();
            }

            if (carry > 0)
            {
                result += carry.ToString();
            }

            char[] res = result.ToCharArray();
            Array.Reverse(res);
            return new string(res);
        }
    }
}
