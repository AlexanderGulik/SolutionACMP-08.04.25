using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace easyRow_0064
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            string input = File.ReadAllText("input.txt");
            string[] parts = input.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int m = int.Parse(parts[0]);
            string[] position = parts[1].Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            int maxPosition = 0;
            foreach (string pos in position) 
            {
            int current = int.Parse(pos);
                if (current > maxPosition)
                {
                    maxPosition = current;
                }
            }
           StringBuilder primeSeries = new StringBuilder();
            int currentNumber = 2;
            while (primeSeries.Length < maxPosition)
            {
                if (ISPrime(currentNumber))
                {
                    primeSeries.Append(currentNumber.ToString());

                }
                currentNumber++;
            }
            StringBuilder result = new StringBuilder();
            foreach (string pos in position) 
            {
            int index = int.Parse(pos)-1;
                result.Append(primeSeries[index]);
            }
            File.WriteAllText("output.txt", result.ToString());


        }

        static bool ISPrime(int number)
        {
            if(number<=1) return false;
            if(number==2) return true;
            if(number%2==0) return false;

            int boundary = (int)Math.Sqrt(number);
            for(int i=3; i <= boundary; i += 2)
            {
                if(number%i==0) return false;
            }
            return true;
        }
    }
}
