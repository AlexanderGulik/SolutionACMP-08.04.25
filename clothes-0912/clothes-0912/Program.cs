using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Schema;
namespace clothes_0912
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("input.txt");
           
            int[] mas = Array.ConvertAll(lines[1].Split(' '), int.Parse).ToArray();
            Dictionary<int, int> counter = new Dictionary<int, int>();
            foreach (int num in mas)
            {
                if (counter.ContainsKey(num))
                {
                    counter[num]++;
                }
                else
                {
                    counter[num] = 1;
                }
            }
            int maxcount = counter.Values.Max();
            var most = counter.Where(x=>x.Value==maxcount).Select(x=> x.Key).ToList();
            int result = most.Count==1?most[0] : 0;
            File.WriteAllText("output.txt", result.ToString());

        }
    }
}
