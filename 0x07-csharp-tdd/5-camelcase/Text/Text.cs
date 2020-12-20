using System;

namespace Text
{
    /// <summary> String class </summary>
    public class Str
    {
        /// <summary> Method to check how many words are in string using CamelCase logic </summary>
        public static int CamelCase(string s)
        {
            if (string.IsNullOrEmpty(s))
                return (0);
            
            int counter = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsUpper(s[i]))
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
