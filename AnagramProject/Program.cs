﻿using System;
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
            string wordToReverse = "A#bc  dfff!$ f#df";

            Anagram anagram = new Anagram();

            Console.WriteLine(anagram.ReverseString(wordToReverse));

            Console.ReadLine();
        }
    }
}
