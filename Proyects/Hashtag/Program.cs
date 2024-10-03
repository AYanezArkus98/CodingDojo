using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = "Here # are some hash#tags: #hello, ##double, #123, and# #validHash";
        string pattern = @"(?<!\S)#+([a-zA-Z]+)\b";

        MatchCollection matches = Regex.Matches(input, pattern);

        List<string> hashtags = new List<string>();

        foreach (Match match in matches)
        {
            hashtags.Add(match.Groups[1].Value);
        }

        Console.WriteLine("Hashtags válidos:");
        foreach (string tag in hashtags)
        {
            Console.WriteLine(tag);
        }
        Console.ReadKey();
    }
}
