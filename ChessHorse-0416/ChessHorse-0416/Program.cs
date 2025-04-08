using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHorse_0416
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText("input.txt").Trim();
            char colum = input[0];
            int row = int.Parse(input[1].ToString());

            int x = colum - 'a' + 1;
            int y = row;
            int[] dx = { 2, 2, 1, 1, -1, -1, -2, -2 };
            int[] dy = { 1, -1, 2, -2, 2, -2, 1, -1 };
            List<string> moves = new List<string>();
            for(int i = 0; i < 8; i++)
            {
                int newX = x + dx[i];
                int newY = y + dy[i];
                if (newX >= 1 && newX <= 8 && newY >= 1 && newY <= 8) 
                {
                    char newColum=(char)('a'+newX-1);
                    moves.Add($"{newColum}{newY}");
                
                }
                moves.Sort();
                File.WriteAllLines("output.txt", moves);
            }
            
        }
    }
}
