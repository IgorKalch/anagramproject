using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AnagramLibrary
{
    public class Anagram
    {
        public string ReverseSingleWord(string data)
        {
            if (string.IsNullOrEmpty(data))
                return data;

            char[] charArray = data.ToCharArray();
            int lenFromEndOfString = data.Length - 1;
            int lenFromBeginOfString = 0;

            while (lenFromBeginOfString < lenFromEndOfString)
            {
                if (!char.IsLetter(charArray[lenFromBeginOfString]))
                    lenFromBeginOfString++;

                else if (!char.IsLetter(charArray[lenFromEndOfString]))
                    lenFromEndOfString--;

                else
                {
                    char tmp = charArray[lenFromBeginOfString];
                    charArray[lenFromBeginOfString] = charArray[lenFromEndOfString];
                    charArray[lenFromEndOfString] = tmp;
                    lenFromBeginOfString++;
                    lenFromEndOfString--;
                }
            }
            return new string(charArray);
        }

        public string ReverseString(string data)
        {
            if (string.IsNullOrEmpty(data))
                return data;

            string[] subs = Regex.Split(data, @"(?<=[\s])");
            string concatRevsrsedString = "";

            foreach (string sub in subs)
            {
                concatRevsrsedString += ReverseSingleWord(sub);
            }
            return concatRevsrsedString;
        }


    }
}
