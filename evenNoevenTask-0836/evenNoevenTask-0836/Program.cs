using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace evenNoevenTask_0836
{
    internal class Program// my solution
    {
        static void Main(string[] args)
        {
            int n = int.Parse(File.ReadLines("input.txt").First().Trim());
            int[] arr = File.ReadLines("input.txt").Skip(1).First().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();


            int[] result = FindEvenNumber(arr);
            Array.Sort(result);
            using (StreamWriter output = new StreamWriter("output.txt"))
            {
                output.WriteLine(result.Length);
                output.WriteLine(string.Join(" ", result));

            }
        }
        static int[] FindEvenNumber(int[] arr)
        {
            System.Collections.Generic.List<int> result = new System.Collections.Generic.List<int>();
            foreach (int num in arr)
            {
                if (num % 2 == 0)
                {
                    string numInE = Convert.ToString(num, 8);

                    if ((numInE[numInE.Length - 3] - '0') % 2 != 0)
                    { result.Add(num); }




                }

            }
            return result.ToArray();

        }

    }
}
/*
 #include <iostream>
#include <fstream>
#include <vector>
#include <algorithm>
#include <sstream>

std::vector<int> FindEvenNumber(const std::vector<int>& arr) {
    std::vector<int> result;
    for (int num : arr) {
        if (num % 2 == 0) {
            std::string numInE;
            int temp = num;
            while (temp != 0) {
                numInE = char('0' + temp % 8) + numInE;
                temp /= 8;
            }
            if (numInE.length() >= 3 && (numInE[numInE.length() - 3] - '0') % 2 != 0) {
                result.push_back(num);
            }
        }
    }
    return result;
}

int main() {
    std::ifstream input("input.txt");
    std::ofstream output("output.txt");

    int n;
    input >> n;
    std::vector<int> arr(n);
    for (int i = 0; i < n; ++i) {
        input >> arr[i];
    }

    std::vector<int> result = FindEvenNumber(arr);
    std::sort(result.begin(), result.end());

    output << result.size() << std::endl;
    for (size_t i = 0; i < result.size(); ++i) {
        if (i != 0) {
            output << " ";
        }
        output << result[i];
    }

    return 0;
}*/