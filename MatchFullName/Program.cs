using System;
using System.Text.RegularExpressions;

namespace MatchFullName
{
    internal class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            Regex regex = new Regex(pattern);

            bool isMatch = regex.IsMatch(text);
            Console.WriteLine(isMatch);
        }
    }
}
