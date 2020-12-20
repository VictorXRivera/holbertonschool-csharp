using System;
using System.Globalization;
using System.Linq;

namespace Text
{
    /// <summary> Str Class </summary>
    public class Str
    {
        /// <summary> method that returns the index of the first non-repeating character of a string. </summary>
        public static int UniqueChar(string s)
        {
            if (string.IsNullOrEmpty(s))
                return (-1);
            int i = 0;
            for (int char_one = 0; char_one < s.Length; char_one++)
            {
                for (int char_two = 0; char_two < s.Length; char_two++)
                {
                    if (s[char_one] == s[char_two])
                        i++;
                }
                if (i == 1)
                    return (char_one);
                i = 0;
            }
            return (-1);
        }
    }
}
