using System;
using System.Globalization;
using System.IO;

namespace DontKnow_0922
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllText("input.txt").Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int t1 = int.Parse(input[0]);// после т1 часов требуют поздярадки
            int t2 = int.Parse(input[1]);// в течении t2
            int s1 = int.Parse(input[2]);// Известно, что за T1 часов полета звездолет улетает на S1 км, а за T2 часов разрядки возвращается на S2 км.
            int s2 = int.Parse(input[3]);
            int s = int.Parse(input[4]);// расстояние S до планет.
            double result = TimeToPlane(t1, t2, s1, s2, s);
           
            if (result < 0)
            {
                File.WriteAllText("output.txt", "NO");
            }
            else { File.WriteAllText("output.txt", result.ToString("0.00", CultureInfo.InvariantCulture)); }






        }
        static double TimeToPlane(int t1, int t2, int s1, int s2, int s)
        {
            if (s == 0) return 0;

            double speedForward = (double)s1 / t1;
            double speedBackward = (double)s2 / t2;

          
            if (s1 <= s2 && s > s1)
            {
                return -1;
            }

            double netDistancePerCycle = s1 - s2;
            double timePerCycle = t1 + t2;

            if (s <= s1)
            {
                return s / speedForward;
            }
            else
            {
                int fullCycles = (int)Math.Floor((s - s1) / netDistancePerCycle);
                double remainingDistance = s - s1 - fullCycles * netDistancePerCycle;

                if (remainingDistance <= 0)
                {
                    return fullCycles * timePerCycle + t1;
                }
                else
                {
                    return fullCycles * timePerCycle + t1 + remainingDistance / speedForward;
                }
            }
        }
    }
}
