using System;
using AnagramLibrary;
using AnagramProject.Properties;
using System.Globalization;

namespace AnagramProject
{
    public class Program
    {
       static void Main(string[] args)
        {
            Anagram anagram = new Anagram();

            Console.WriteLine(Resources.greeting);
            Console.WriteLine(Resources.queryToEnterText);
            string wordToReverse = Console.ReadLine();

            string result = Resources.emptyString;
            if (!string.IsNullOrEmpty(wordToReverse))
            {
                result = $"{Resources.result}{anagram.Reverse(wordToReverse)}";
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
