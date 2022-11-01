using System;
using System.Reflection;
using System.Resources;
using AnagramLibrary;

namespace AnagramProject
{
    public class Program
    {
       static void Main(string[] args)
        {
            Anagram anagram = new Anagram();
            ResourceManager rm = new ResourceManager("AnagramProject.Resources.ResourceEn", Assembly.GetExecutingAssembly());

            Console.WriteLine(rm.GetString("greeting"));
            Console.WriteLine(rm.GetString("queryToEnterText"));
            string wordToReverse = Console.ReadLine();

            if (string.IsNullOrEmpty(wordToReverse))
            {
                Console.WriteLine(rm.GetString("emptyString"));
            }
            else
            {
                Console.WriteLine($"{rm.GetString("enteredString")}{wordToReverse}");
                Console.WriteLine($"{rm.GetString("result")}{anagram.ReverseString(wordToReverse)}");

            }                        

            Console.ReadLine();
        }
    }
}
