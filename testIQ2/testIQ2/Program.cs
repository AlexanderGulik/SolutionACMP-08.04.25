using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testIQ2
{
    internal class Program
    {//провал
        static void Main(string[] args)
        {
            string[] input = File.ReadAllText("input.txt").Split();
            string n1= input[0];
            string n2= input[1];
            string result = sumString(n1, n2);
            File.WriteAllText("output.txt", result);
        }
        static string sumString(string n1, string n2) 
        {
            int maxLength = Math.Max(n1.Length, n2.Length);
            char[] chars1= n1.PadLeft(maxLength, '0').ToCharArray();
            char[] chars2 = n2.PadLeft(maxLength, '0').ToCharArray();
            string result = "";
            int carry = 0;
            
            for (int i = maxLength-1; i >= 0; i--) 
            {
            int digit1 = chars1[i]-'0';
            int digit2 = chars2[i]-'0';
                int sum = digit1 + digit2+carry;
                result = (sum % 10).ToString() + result;
                carry = sum / 10;
            
            }
            if (carry > 0)
            {
                result =carry.ToString()+result;
            }
            return result;
        
        }
    }
}
