using System.IO;

namespace ButefleNumber_0383
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(File.ReadAllText("input.txt").Trim());
            int result = FindBeautiful(n);
            File.WriteAllText("output.txt", result.ToString());
        }
        static int FindBeautiful(int n)
        {
            int count = 0;
            int number = 1;
            while (true)
            {
                if (Beautiful(number))
                {
                    count++;
                    if (count == n)
                    {
                        return number;
                    }
                }
                number++;

            }
        }
        static bool Beautiful(int num)
        {
            int sum = 0;
            int digits = 0;
            int temp = num;
            while (temp > 0)
            {
                sum += temp % 10;
                digits++;
                temp /= 10;

            }
            return digits > 0 && sum % digits == 0;

        }
    }
}
