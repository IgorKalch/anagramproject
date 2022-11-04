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

            Console.WriteLine(Resources.Greeting);
            Console.WriteLine(Resources.QueryToEnterText);
            string wordToReverse = Console.ReadLine();

            string result = Resources.EmptyString;
            if (!string.IsNullOrEmpty(wordToReverse))
            {
                result = string.Format(Resources.Result, anagram.Reverse(wordToReverse));
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
