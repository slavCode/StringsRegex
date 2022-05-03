using System;
using System.Linq;

namespace ReverseString
{
    internal class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            var reversed = text.Reverse();
            Console.WriteLine(String.Join("", reversed));
        }
    }
}
