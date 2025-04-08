using System.Collections.Generic;
using System.IO;

namespace BlackWhiterGraphic_0530
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("input.txt");
            string[] fitstLine = input[0].Split(' ');
            int w = int.Parse(fitstLine[0]);
            int h = int.Parse(fitstLine[1]);
            string logic = input[h + h + 1];
            List<string> multOne = new List<string>();
            for (int i = 1; i <= h; i++)
            {
                multOne.Add(input[i]);

            }

            List<string> multTwo = new List<string>();
            for (int i = h + 1; i <= h + h; i++)
            {
                multTwo.Add(input[i]);

            }
            List<string> result = new List<string>();
            for (int i = 0; i < h; i++)
            {
                string numOne = multOne[i];
                string numTwo = multTwo[i];
                string line = FindBool(numOne, numTwo, w, logic);
                result.Add(line);
            }
            using (StreamWriter output = new StreamWriter("output.txt"))
            {
                foreach (var item in result)
                {
                    output.WriteLine(item.ToString());
                }
            }

        }
        static string FindBool(string n1, string n2, int w, string logic)
        {
            char[] charN1 = n1.ToCharArray();
            char[] charN2 = n2.ToCharArray();
            char[] line = new char[w];
            char[] l = logic.ToCharArray();
            for (int i = 0; i < w; i++)
            {
                if (charN1[i] == '0' && charN2[i] == '0')
                {
                    line[i] = l[0];
                }
                else if (charN1[i] == '0' && charN2[i] == '1')
                {
                    line[i] = l[1];
                }
                else if (charN1[i] == '1' && charN2[i] == '0')
                {
                    line[i] = l[2];
                }
                else if (charN1[i] == '1' && charN2[i] == '1')
                {
                    line[i] = l[3];
                }
            }
            return new string(line);
        }
    }
}
