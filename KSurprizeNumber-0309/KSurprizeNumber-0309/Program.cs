using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSurprizeNumber_0309
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            int k = int.Parse(File.ReadAllText("input.txt"));
            int count = 0;
            for (int i = 0; i < k; i++)
            {
                int number = revesed(i);
            if(number+i == k)
                {
                    count++;
                }
            }
            File.WriteAllText("output.txt", count.ToString());
        }

        static int revesed(int number) 
        {
        int reversed = 0;
            while (number > 0) 
            {
                reversed = reversed * 10 + number%10;
                number /= 10;
            
            }
            return reversed;
        
        }



    }
}
