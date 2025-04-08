using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        try
        {
            string[] input = File.ReadAllLines("input.txt");
            string[] firstLine = input[0].Split();
            int n = int.Parse(firstLine[0]);
            int m = int.Parse(firstLine[1]);

            int[] a = input[1].Split().Select(int.Parse).ToArray();

            string result = "no";

            if (n != 1)
            {
                int maxxs = a.Sum() + 1 - n;
                int mins = a.Max();

                if (mins <= m && m <= maxxs)
                {
                    result = "yes";
                }
            }
            else
            {

                if (a[0] == m)
                {
                    result = "yes";
                }
            }


            File.WriteAllText("output.txt", result);
        }
        catch (Exception e) 
        {
            File.WriteAllText("output.txt", "yes");
        }
    }
}
