using System;
using System.Collections.Generic;
using System.Linq;

namespace Palindromes
{
    internal class Program
    {
        static void Main()
        {
            string[] words = Console.ReadLine().Split(new char[]
            { ' ', '/', ',', '!' , '?' , '.', '\'', '"'}, StringSplitOptions.RemoveEmptyEntries);

            var palindromes = new List<string>();
            foreach (string word in words)
            {
                int index = word.Length;
                if (index == 1) palindromes.Add(word);
                else
                {
                    string leftSide = word.Substring(0, index / 2);
                    string rightSide = "";
                    if (index % 2 == 0)
                    {
                        rightSide = word.Substring(index / 2);
                    }
                    else
                    {
                        rightSide = word.Substring((index + 1) / 2);
                    }

                    bool isPalidrome = IsPalindrome(leftSide, rightSide);
                    if (isPalidrome) palindromes.Add(word);
                }
            }

            Console.WriteLine(String.Join(", ", palindromes.Distinct().OrderBy(w => w)));
        }

        static bool IsPalindrome(string leftSide, string rightSide)
        {
            bool isPalindrome = false;

            var reversedArr = rightSide.Reverse();
            string reversed = String.Join("", reversedArr);

            if (leftSide == reversed) isPalindrome = true;
            return isPalindrome;
        }
    }
}
