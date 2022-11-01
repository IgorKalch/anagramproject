using System.Text.RegularExpressions;

namespace AnagramLibrary
{
    public class Anagram
    {
        public string Reverse(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                return string.Empty;
            }

            string[] subs = Regex.Split(data, @"(?<=[\s])");
            string concatRevsrsedString = "";

            foreach (string sub in subs)
            {
                concatRevsrsedString += ReverseWord(sub);
            }
            return concatRevsrsedString;

        }
        string ReverseWord(string word)
        {
            char[] charArray = word.ToCharArray();
            int lenFromEndOfString = word.Length - 1;
            int lenFromBeginOfString = 0;

            while (lenFromBeginOfString < lenFromEndOfString)
            {
                if (!char.IsLetter(charArray[lenFromBeginOfString]))  {
                    lenFromBeginOfString++;
                }  else if (!char.IsLetter(charArray[lenFromEndOfString]))  { 
                    lenFromEndOfString--; 
                } else {
                    char tmp = charArray[lenFromBeginOfString];
                    charArray[lenFromBeginOfString] = charArray[lenFromEndOfString];
                    charArray[lenFromEndOfString] = tmp;
                    lenFromBeginOfString++;
                    lenFromEndOfString--;
                }
            }
            return new string(charArray);
        }
    }
}
