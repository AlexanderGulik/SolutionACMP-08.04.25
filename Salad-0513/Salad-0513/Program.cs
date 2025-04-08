using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salad_0513
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(File.ReadAllText("input.txt"));
            long result = (1L << n) - n - 1;//2^n-n-1
            File.WriteAllText("output.txt",result.ToString());
        }
    }
}
