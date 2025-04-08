using System;
using System.IO;
using System.Linq;

namespace MinSystem_0315
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            string s;
            char max1 = '0';
            s = File.ReadAllText("output.txt").Trim();
            if (s.Length == 0)
            {
                File.WriteAllText("output.txt", "-1");
                return;
            }
            for (int z = 0; z < s.Length; z++) 
            {
                if (s[z] == '0' || (s[z] > '9' && s[z] < 'A') || s[z] > 'Z') 
                {
                    File.WriteAllText("output.txt", "-1");
                    return;
                
                }
                else
                {
                    max1 = max1 > s[z]?max1: s[z];
                }
            
            }
            if (max1 == '0')
            {
                File.WriteAllText("output.txt", "2");
                return;
            }
            if (max1 <= '9')
            {
                File.WriteAllText("output.txt", ((int)max1 + 1 - (int)'0').ToString());

            }
            else
            {
                File.WriteAllText("output.txt",((int)(max1-'A')+11).ToString());
            }



        }
       
       
    }
}
