using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnagramLibrary;

namespace AnagramProject
{
    public class Program
    {
       static void Main(string[] args)
        {
            Anagram anagram = new Anagram();

            Console.WriteLine("Please enter the string that should be anagrammed and press enter\n");
            string wordToReverse = Console.ReadLine();

            if(string.IsNullOrEmpty(wordToReverse))
                Console.WriteLine("Your's string is empty");
            else
            {
                Console.WriteLine($"Your's string: {wordToReverse}\n");
                Console.WriteLine($"Anagram: {anagram.ReverseString(wordToReverse)}\n");
            }

            Console.ReadLine();
        }
    }
}
