/*
In this example you have to validate if a user input string is alphanumeric. 
The given string is not nil/null/NULL/None, so you don't have to check that.

The string has the following conditions to be alphanumeric:

At least one character ("" is not valid)
Allowed characters are uppercase / lowercase latin letters and digits from 0 to 9
No whitespaces / underscore

 */

using System.Text.RegularExpressions;

namespace Kata.Kyu6.Alphanumeric
{
    public class SolutionClass
    {
        public static bool Alphanumeric(string str) => new Regex("^[a-zA-Z0-9]+$").Match(str).Success;

        /*
         * Brute Force
        if (str.Length == 0) return false;
        string pattern = "[^0-9a-zA-Z]+";
        string replacement = "";
        string result = Regex.Replace(str, pattern, replacement);
        return result == str;
        */
    }
}
