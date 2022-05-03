using System;
using System.Linq;

namespace TextFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var text = Console.ReadLine();

            foreach (var word in bannedWords)
            {
                var censoredWord = "";
                for (int i = 0; i < word.Length; i++) censoredWord += '*';

                text = text.Replace(word, censoredWord);
            }
            Console.WriteLine(text);
        }
    }
}
