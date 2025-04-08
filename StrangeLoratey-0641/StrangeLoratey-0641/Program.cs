using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrangeLoratey_0641
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText("input.txt").Trim();
            string result = getMaxNum(input);
            File.WriteAllText("output.txt", result);
        }
        static string getMaxNum(string n)
        {
            StringBuilder stac = new StringBuilder();
            int removeCount = 2;
            foreach (char c in n) 
            {
                while (stac.Length > 0 && stac[stac.Length - 1] < c && removeCount > 0) 
                {
                    stac.Length--;
                    removeCount--;
                
                }
                stac.Append(c);
            
            
            }
            while (removeCount > 0) 
            {
                stac.Length--;
                removeCount--;
            
            }
            return stac.ToString();
        }
    }
}
