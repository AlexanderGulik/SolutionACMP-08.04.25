using System;
using System.IO;

namespace funnyGame_0208
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            int n = int.Parse(File.ReadAllText("input.txt".Trim()));
            string binarry = Convert.ToString(n, 2);

            string maxBinarry = binarry;
            string current = binarry;

            for (int i = 0; i < binarry.Length; i++)
            {
                current = current[current.Length - 1]+current.Substring(0,current.Length-1);
                if(string.Compare(current, maxBinarry, StringComparison.OrdinalIgnoreCase) > 0)
                {
                    maxBinarry = current;
                }

            }
            int result = Convert.ToInt32(maxBinarry, 2);
            File.WriteAllText("output.txt", result.ToString());



        }
    }
}
