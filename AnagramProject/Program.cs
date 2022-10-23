using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wordToReverse = "A!b Cde#f  ewrff    jk";

            Anagram anagram = new Anagram();

            Console.WriteLine(anagram.ReverseString(wordToReverse));

            Console.ReadLine();
        }
    }
}
