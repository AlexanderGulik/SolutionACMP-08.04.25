using System;
using System.IO;

namespace jumpTrevel_0986
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("input.txt"))
            {
             
                string[] firstLine = reader.ReadLine().Split(' ');
                int n = int.Parse(firstLine[0]); 
                int forgX = int.Parse(firstLine[1]); 
                int frogY = int.Parse(firstLine[2]); 
                int tongueLength = int.Parse(firstLine[3]);

               
                int tongueLengthSquared = tongueLength * tongueLength;

                
                for (int i = 1; i <= n; i++)
                {
                    string[] point = reader.ReadLine().Split(' ');
                    int x = int.Parse(point[0]);
                    int y = int.Parse(point[1]);

                  
                    int distanceSquared = (x - forgX) * (x - forgX) + (y - frogY) * (y - frogY);

                   
                    if (distanceSquared <= tongueLengthSquared)
                    {
                        File.WriteAllText("output.txt", i.ToString());
                        return;
                    }
                }
            }

          
            File.WriteAllText("output.txt", "Yes");
        }
    }
}
/*
 using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jumpTrevel_0986
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("input.txt");
            string[] firstLine = input[0].Split(' ');
            int n = int.Parse(firstLine[0]);
            int forgX = int.Parse(firstLine[1]);
            int frogY = int.Parse(firstLine[2]);
            int tengleLenght = int.Parse(firstLine[3]);

            for (int i = 1; i <= n; i++) 
            {
                string[] point = input[i].Split(' ');
                int x = int.Parse(point[0]);
                int y = int.Parse(point[1]);

                int dictance = (x - forgX) * (x - forgX) + (y - frogY) * (y - frogY);
                if (dictance <= tengleLenght * tengleLenght)
                {
                    File.WriteAllText("output.txt", i.ToString());
                    return;
                }

            }
            File.WriteAllText("output.txt", "Yes");


        }
    }
}

 
 */