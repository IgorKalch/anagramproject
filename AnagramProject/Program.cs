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

            if (string.IsNullOrEmpty(wordToReverse))
            {
                Console.WriteLine(Resources.emptyString);
            }
            else
            {
                Console.WriteLine($"{Resources.enteredString}{wordToReverse}");
                Console.WriteLine($"{Resources.result}{anagram.Reverse(wordToReverse)}");

            }                        

            Console.ReadLine();
        }
    }
}
