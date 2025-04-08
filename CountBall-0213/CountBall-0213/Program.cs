using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountBall_0213
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputLines = File.ReadAllLines("input.txt");
            int index = 0;
            int n = int.Parse(inputLines[index++]);
            int[] testScores = inputLines[index++].Split(' ').Select(int.Parse).ToArray();
            int bonus = int.Parse(inputLines[index++]);
            int m = int.Parse(inputLines[index++]);
            int[][] attempts = new int[m][];
            for(int i = 0; i < m; i++)
            {
                attempts[i]= inputLines[index++].Split(' ').Select(int.Parse).ToArray();
            }
            int maxScore = 0;
            int[] results = new int[m];
            for (int i = 0; i < m; i++) 
            {
            int currentScore = 0;
                bool allPassed = true;
                for (int j = 0; j < n; j++) 
                {
                    if (attempts[i][j] == 1)
                    {
                        currentScore += testScores[j];
                    }
                    else
                    {
                        allPassed = false;
                    }
                }
                if (allPassed)
                {
                    currentScore += bonus;
                }
                int penalty = 2 * i;
                currentScore -= penalty;
                if(currentScore < 0)
                {
                    currentScore = 0;
                }
                if(currentScore > maxScore)
                {
                    maxScore = currentScore;
                }
                results[i]=maxScore;

            }
            File.WriteAllText("output.txt", string.Join("\n", results));
        }
    }
}
