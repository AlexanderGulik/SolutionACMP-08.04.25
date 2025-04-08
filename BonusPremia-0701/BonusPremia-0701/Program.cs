using System;
using System.IO;

namespace BonusPremia_0701
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllText("input.txt").Split();
            int age = int.Parse(input[0]);
            string prem = input[1];
            int baseSystem = (age % 10) + 2;
            int res = decminalConvert(prem, baseSystem);
            File.WriteAllText("output.txt", res.ToString());
          
        }
        static int decminalConvert(string prem, int baseSystem)

        {
            int result = 0;
            for (int i = 0; i < prem.Length; i++) 
            {
                char c = prem[i];
                int digit = ConverDigit(c);
                result=result *baseSystem + digit;
            
            }
            return result;

        }
        static int ConverDigit(char c) 
        {
            if (char.IsDigit(c))
            {
                return c-'0';
            }
            else
            {
                return c-'A'+10;
            }
        
        
        }


    }
}
