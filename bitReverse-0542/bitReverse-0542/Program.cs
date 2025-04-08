using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitReverse_0542
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(File.ReadAllText("input.txt").Trim());
            string binary = Convert.ToString(m,2);
            char[] reversd = binary.ToCharArray();
            Array.Reverse(reversd);
            int result = Convert.ToInt32(new string(reversd),2);
           File.WriteAllText("output.txt", result.ToString());
        }
    }
}
