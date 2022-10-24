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
            {
                throw new ArgumentNullException(nameof(data));
            }

            char[] charArray = data.ToCharArray();
            int lenFromBeginOfString = data.Length - 1;
            int lenFromEndOfString = 0;

            while (lenFromEndOfString < lenFromBeginOfString)
            {
                // Ignore special characters
                if (!char.IsLetter(charArray[lenFromEndOfString]))
                    lenFromEndOfString++;
                else if (!char.IsLetter(charArray[lenFromBeginOfString]))
                    lenFromBeginOfString--;

                // Both charArray[lenFromEndOfString] and charArray[lenFromBeginOfString]) are not spacial
                else
                {
                    char tmp = charArray[lenFromEndOfString];
                    charArray[lenFromEndOfString] = charArray[lenFromBeginOfString];
                    charArray[lenFromBeginOfString] = tmp;
                    lenFromEndOfString++;
                    lenFromBeginOfString--;
                }
            }
            return new string(charArray);
        }

        public string ReverseString(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                throw new ArgumentNullException(nameof(data));
            }
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
