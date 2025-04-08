using System.IO;

namespace money2_0543
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllText("input.txt").Split(' ');
            int n = int.Parse(input[0]);//корзин&&послед
            int w = int.Parse(input[1]);//грамм
            int d = int.Parse(input[2]);//до грамм
            int p = int.Parse(input[3]);

            int s = w * (n - 1) * n / 2;
            int delta = s - p;

            int k;

            if (delta == 0)
            {
                k = n;


            }
            else
            {
                k = delta / d;
            }
            File.WriteAllText("output.txt", k.ToString());

        }

    }
}
