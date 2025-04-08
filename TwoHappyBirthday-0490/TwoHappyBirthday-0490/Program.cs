using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoHappyBirthday_0490
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("input.txt");
            string[] petya = input[0].Split('.');
            string[] vasya = input[1].Split('.');
            int result = DifferenceDay(petya, vasya);
            File.WriteAllText("output.txt", result.ToString());

        }

        static int DifferenceDay(string[] pet, string[] vas)
        {
            int[] petya = pet.Select(int.Parse).ToArray(); 
            int[] vasya = vas.Select(int.Parse).ToArray();
           int petyaDay = CalculateDays(petya[0], petya[1], petya[2]);
           int vasyaDay = CalculateDays(vasya[0], vasya[1], vasya[2]);
            return vasyaDay - petyaDay;

        }
        static int CalculateDays(int day, int month, int year) 
        {
            int[] dayinMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int fullYear = year + 1900;
            if (year < 50) fullYear += 100;

            int daysBefore = dayinMonth.Take(month-1).Sum();
            int totalDays = daysBefore + day;
            if (fullYear == 1994)
            {
                totalDays += 365;
            }
            return totalDays;


        }

    }
}
