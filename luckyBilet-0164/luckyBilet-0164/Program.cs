using System.IO;

namespace luckyBilet_0164
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText("input.txt").Trim();
            bool result = CheckBilet(input);

            File.WriteAllText("output.txt", result ? "YES" : "NO");
        }
        static bool CheckBilet(string input)
        {
            if (input.Length < 2) return false;
            char[] a = input.ToCharArray();
            int k = 1;
            int sum1 = 0;
            int sum2 = -1;
            while (sum1 != sum2 && k < a.Length)
            {
                for (int i = 0; i < k; i++)
                {
                    sum1 += a[i] - '0';

                }
                sum1 = sum(sum1);
                sum2 += 1;
                for (int i = k; i < a.Length; i++)
                {
                    sum2 += a[i] - '0';
                }
                sum2 = sum(sum2);
                if (sum1 == sum2)
                    break;
                sum1 = 0;
                sum2 = -1;
                k++;


            }
            return sum1 == sum2;
        }
        static int sum(int num)
        {
            while (num > 9)
            {
                int sum = 0;
                foreach (char c in num.ToString())
                {
                    sum += c - '0';

                }
                num = sum;
            }
            return num;

        }
    }
}
