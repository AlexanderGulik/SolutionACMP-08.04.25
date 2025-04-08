using System.IO;

namespace AntiPalidrom_0491
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText("input.txt").Trim();
            string Antipalindrom = FindAntiPalidrom(input);
            File.WriteAllText("output.txt", Antipalindrom);
        }
        static string FindAntiPalidrom(string input)
        {
        if(!FullPalidrom(input)) return input;
        string candidateOne = input.Substring(0,input.Length-1);
            string candidateTwo = input.Substring(1);

            if(!FullPalidrom(candidateOne)) return candidateOne;
            if(!FullPalidrom(candidateTwo)) return candidateTwo;
            return "NO SOLUTION";

        }
        static bool FullPalidrom(string input)
        {

            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input[i] != input[input.Length - 1 - i])
                    return false;
            }
            return true;
        }
    }
}