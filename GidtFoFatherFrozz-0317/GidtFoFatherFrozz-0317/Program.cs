using System.IO;

namespace GidtFoFatherFrozz_0317
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllText("input.txt").Split(' ');
            int x = int.Parse(input[0]);
            int y = int.Parse(input[1]);
            int z = int.Parse(input[2]);
            int w = int.Parse(input[3]);
            int result = CountDifferentGift(x, y, z, w);
            File.WriteAllText("output.txt", result.ToString());

        }
        static int CountDifferentGift(int x, int y, int z, int w)
        {
            int countGift = 0;
            //int i_max = w / x;
            //int j_max = w / y;
            //int k_max = w / z;
            for (int i = 0; i <= w / x; i++)
            {
                for (int j = 0; j <=(w - i * x) / y; j++)
                {
                    int remaining = w - i * x - j * y;
                    if (remaining >= 0 && remaining % z == 0)
                    {
                        int k = remaining / z;
                        if (k >= 0)
                        {
                            countGift++;
                        }
                    }
                }


            }

            return countGift;
        }
    }
}
