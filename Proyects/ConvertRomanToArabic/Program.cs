using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(RomanToArabic("XIV")); // Salida: 14
        Console.WriteLine(RomanToArabic("MCMXCIV")); // Salida: 1994
        Console.ReadKey();
    }

    public static int RomanToArabic(string roman)
    {
        Dictionary<char, int> romanMap = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        int arabic = 0;
        for (int i = 0; i < roman.Length; i++)
        {
            if (i + 1 < roman.Length && romanMap[roman[i]] < romanMap[roman[i + 1]])
            {
                arabic -= romanMap[roman[i]];
            }
            else
            {
                arabic += romanMap[roman[i]];
            }
        }

        return arabic;
    }
}
