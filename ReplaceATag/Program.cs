using System;
using System.Text.RegularExpressions;

namespace ReplaceATag
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                string replacment = $@"[URL href=$1]$2[/URL]";
                string pattern = @"<a.*?href.*?""(.*)"">(.*?)<\/a>";
                string replaced = Regex.Replace(input, pattern, replacment);

                Console.WriteLine(replaced);

                input = Console.ReadLine();
            }
        }
    }
}
