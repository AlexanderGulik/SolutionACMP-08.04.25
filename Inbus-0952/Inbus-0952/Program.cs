using System;
using System.IO;

namespace Inbus_0952
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(StreamReader inputFile = new StreamReader("input.txt"))
        using (StreamWriter outputFile = new StreamWriter("output.txt"))
            {
                string[] line = inputFile.ReadLine().Split(' ');
                int a = int.Parse(line[0]); 
                int b = int.Parse(line[1]); 

                string ans;

                if (a == 0 && b == 0)
                {
                    ans = "0 0";
                }
                else
                {
                    if (a == 0)
                    {
                        ans = "Impossible";
                    }
                    else
                    {
                        if (b == 0)
                        {
                            ans = $"{a} {a}";
                        }
                        else
                        {
                            if (b <= a)
                            {
                                ans = $"{a} {a + b - 1}";
                            }
                            else
                            {
                                ans = $"{b} {a + b - 1}";
                            }
                        }
                    }
                }

                if (a == 0 && b != 0)
                {
                    ans = "Impossible";
                }

                outputFile.WriteLine(ans);
            }
        }
    }
}
