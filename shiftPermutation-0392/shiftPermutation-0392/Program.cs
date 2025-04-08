using System.IO;
using System.Linq;

namespace shiftPermutation_0392
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            string[] input = File.ReadAllLines("input.txt");
            int n = int.Parse(input[0]);
            int[] permutation = input[1].Split().Select(int.Parse).ToArray();
            int[] doubled = permutation.Concat(permutation).ToArray();
            int minStart = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (doubled[i + j] < doubled[j + minStart])
                    {
                        minStart = i;
                        break;
                    }
                    else if (doubled[i + j] > doubled[j + minStart])
                    {
                        break;
                    }
                }

            }
            int[] result = doubled.Skip(minStart).Take(n).ToArray();
            File.WriteAllText("output.txt", string.Join(" ", result));

        }


    }
}
