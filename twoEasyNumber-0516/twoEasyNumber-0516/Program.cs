using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twoEasyNumber_0516
{
    internal class Program
    {
        static bool IsPrime(int n)
        {
            if(n<=1) return false;
            if(n==2) return true;
            if(n%2==0) return false;
            for(int i = 3; i * i <= n; i += 2)
            {
                if(n%i==0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            string input = File.ReadAllText("input.txt").Trim();
            int n = int.Parse(input);
            string digits = n.ToString();
            var acced=digits.OrderBy(c=>c).ToArray();
            var descend = digits.OrderByDescending(c=>c).ToArray(); 
            int accedN = int.Parse(new string(acced));
            int descendN= int.Parse(new string(descend));

            bool isaccedP=IsPrime(accedN);
            bool idescendP= IsPrime(descendN);
            string result = (isaccedP && idescendP) ? "Yes" : "No";
            File.WriteAllText("output.txt",result);


        }
    }
}
