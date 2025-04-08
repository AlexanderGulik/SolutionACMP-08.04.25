using System.IO;

namespace PasyanOldSHapaklyak_0521
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllText("input.txt").Split();
            int n = int.Parse(input[0]);
            int p = int.Parse(input[1]);

            int step = 0;
            bool isConvergin = true;
            for (int cards = n; cards <= p; cards++)
            {
                int steps = 0;
                int currentCards = cards;
                while (currentCards != 2)
                {
                    if (currentCards == 1)
                    {
                        isConvergin = false;
                        break;
                    }
                    if (currentCards % 2 == 0)
                    {
                        currentCards /= 2;

                    }
                    else
                    {
                        currentCards = currentCards * 3 + 1;


                    }
                    steps++;


                }
                if (!isConvergin) break;
                step += steps;


            }
            if (isConvergin) { File.WriteAllText("output.txt", step.ToString()); }
            else
            {
                File.WriteAllText("output.txt", "0");
            }

        }

    }
}

