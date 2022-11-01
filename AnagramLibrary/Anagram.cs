using System.Text.RegularExpressions;

namespace AnagramLibrary
{
    public class Anagram
    {
        public string ReverseString(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                return string.Empty; 
            }

            string[] subs = Regex.Split(data, @"(?<=[\s])");
            string concatRevsrsedString = "";

            foreach (string sub in subs)
            {
                int lenFromEndOfString = sub.Length - 1;
                int lenFromBeginOfString = 0;
                char[] charArray = sub.ToCharArray();

                while (lenFromBeginOfString < lenFromEndOfString)
                {
                    if (!char.IsLetter(charArray[lenFromBeginOfString]))
                    {
                        lenFromBeginOfString++;
                    }
                    else if (!char.IsLetter(charArray[lenFromEndOfString]))
                    {
                        lenFromEndOfString--;
                    }
                    else
                    {
                        char tmp = charArray[lenFromBeginOfString];
                        charArray[lenFromBeginOfString] = charArray[lenFromEndOfString];
                        charArray[lenFromEndOfString] = tmp;
                        lenFromBeginOfString++;
                        lenFromEndOfString--;
                    }
                }
                concatRevsrsedString += new string(charArray);
            }
            return concatRevsrsedString;
        }
    }
}
