using System;
using System.IO;

class Program
{
    static void Main()
    {
        string[] input = File.ReadAllText("INPUT.TXT").Split();
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);
        int c = int.Parse(input[2]);

        string result = ConstructTrinomial(a, b, c);
        File.WriteAllText("OUTPUT.TXT", result);
    }

    static string ConstructTrinomial(int a, int b, int c)
    {
        string partA = FormatTerm(a, "");
        string partB = FormatTerm(b, "x");
        string partC = FormatTerm(c, "y");

        string result = partA;

        if (!string.IsNullOrEmpty(partB))
        {
            if (string.IsNullOrEmpty(result))
            {
                result = partB;
            }
            else
            {
                if (partB[0] == '-')
                {
                    result += partB;
                }
                else
                {
                    result += "+" + partB;
                }
            }
        }

        if (!string.IsNullOrEmpty(partC))
        {
            if (string.IsNullOrEmpty(result))
            {
                result = partC;
            }
            else
            {
                if (partC[0] == '-')
                {
                    result += partC;
                }
                else
                {
                    result += "+" + partC;
                }
            }
        }

        if (string.IsNullOrEmpty(result))
        {
            result = "0";
        }

        return result;
    }

    static string FormatTerm(int coefficient, string variable)
    {
        if (coefficient == 0)
        {
            return "";
        }

        string term = "";

        if (coefficient == 1 && !string.IsNullOrEmpty(variable))
        {
            term = variable;
        }
        else if (coefficient == -1 && !string.IsNullOrEmpty(variable))
        {
            term = "-" + variable;
        }
        else
        {
            term = coefficient.ToString();
            if (!string.IsNullOrEmpty(variable))
            {
                term += variable;
            }
        }

        return term;
    }
}