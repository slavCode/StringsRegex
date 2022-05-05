using System;
using System.Text.RegularExpressions;

namespace MatchPhoneNumber
{
    internal class Program
    {
        static void Main()
        {
            string pattern = @"(\+359-\d-\d{3}-\d{4}\b)|(\+359 \d \d{3} \d{4}\b)";
            string text = Console.ReadLine();

            var matches = Regex.Matches(text, pattern);
            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
