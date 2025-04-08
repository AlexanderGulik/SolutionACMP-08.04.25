using System.IO;
using System.Linq;
namespace numerlog_0095
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText("INPUT.TXT").Trim();

            int step = 0;
            string result;
            if (input.Length == 1)
            {
                result = $"{input} {step}";
                File.WriteAllText("OUTPUT.TXT", result);
                return;
            }

            while (input.Length > 1)
            {

                char[] kolvo = input.ToCharArray();
                int sum = kolvo.Select(c => int.Parse(c.ToString())).Sum();
                input = sum.ToString();
                step++;
            }



            result = $"{input} {step}";
            File.WriteAllText("OUTPUT.TXT", result);



        }
    }
}
