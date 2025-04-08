using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//пройдено
namespace testIQ3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllText("input.txt").Split();
            string n1 = input[0];
            string n2 = input[1];
            string result = sumString(n1, n2);
            File.WriteAllText("output.txt", result);

        }
        static string sumString(string n1, string n2) 
        {
        int maxLentgh = Math.Max(n1.Length, n2.Length);
            char[] arr1 = n1.ToCharArray();
            char[] arr2 = n2.ToCharArray();
            string result = "";
            Array.Reverse(arr1);
            Array.Reverse(arr2);
            int cros = 0;
            for (int i = 0; i < maxLentgh; i++) 
            {
                int digit1 = (i < arr1.Length) ? arr1[i] - '0':0 ;
                int digit2 = (i < arr2.Length) ? arr2[i] - '0':0 ;
                int sum = digit1 + digit2+cros;
                cros = sum/10;
                result += sum % 10;

            }
            if (cros > 0)
            {
                result += cros.ToString();
            }
            char[]res = result.ToCharArray();
            Array.Reverse(res);
            return new string (res);

        }
    }
}
