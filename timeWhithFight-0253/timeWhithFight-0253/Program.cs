using System.IO;

namespace timeWhithFight_0253
{
    internal class Program
    {
        static void Main(string[] args)
        {//3
            string[] input = File.ReadAllLines("input.txt");
            string[] startTime = input[0].Split(' ');
            string[] finishTime = input[1].Split(' ');
            int startHours = int.Parse(startTime[0]);
            int startMin = int.Parse(startTime[1]);

            int finishHours = int.Parse(finishTime[0]);
            int finishMin = int.Parse(finishTime[1]);
           
            int result = CountStrike(startHours, startMin, finishHours, finishMin);
            File.WriteAllText("output.txt", result.ToString());


        }
        //2
        static int CountStrike(int h1, int m1, int h2, int m2)
        {
            int totaltik = 0;
            if (h1 > h2 || (h1 == h2 && m1 > m2))
            {
                totaltik += intervalStrike(h1, m1, 23, 59);
                totaltik += intervalStrike(0, 0, h2, m2);

            }
            else
            {
                totaltik += intervalStrike(h1, m1, h2, m2);
            }
            return totaltik;

        }
        //1
        static int intervalStrike(int h1, int m1, int h2, int m2)
        {
            int strikes = 0;
            for (int hour = h1; hour <= h2; hour++)
            {//1
                int actualHour = (hour % 12 == 0) ? 12 : hour % 12;

                if (hour == h1 && m1 == 0)
                {
                    strikes += actualHour;
                }
                else if (hour > h1)
                {
                    strikes += actualHour;
                }
                if ((hour > h1 || m1 <= 30) && (hour < h2 || m2 >= 30))
                {
                    strikes++;
                }
                

            }
            return strikes;
        }
    }
}
