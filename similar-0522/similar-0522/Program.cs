using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace similar_0522
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("input.txt");
            string[] firstLines = lines[0].Split();
            string[] secondLines = lines[1].Split();
            string[] thrideLines = lines[2].Split();

            int[] arr1 = Array.ConvertAll(secondLines, int.Parse).ToArray();
            int[] arr2 = Array.ConvertAll(thrideLines, int.Parse).ToArray();
            
           var set1 = new HashSet<int>(arr1);
           var set2 = new HashSet<int>(arr2);
            bool test = set1.SetEquals(set2);
            


          
            File.WriteAllText("output.txt", test?"1":"0");
            
        }
    }
}
