using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace Text
{
    /// <summary> Str class </summary>
    public class Str
    {
        /// <summary> Palindrome method </summary>
        public static bool IsPalindrome(string s)
        {
            s = Regex.Replace(s, "[:;,. \t\n\r]", "");
            string new_s = new string(s.Reverse().ToArray());
            if (s == new_s)
                return true;
            else
                return false;
        }
    }
}
