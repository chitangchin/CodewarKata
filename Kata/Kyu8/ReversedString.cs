namespace Kata.ReversedString
{
    using System;
    public class SolutionClass
    {
        public static string Solution(string str)
        {
            //             //Initiate String result Variable
            //             string result = "";
            //             //Iterate through the string from the end to the beginning
            //             for (int i = str.Length - 1; i >= 0; i--)
            //             {
            //                 //str[i] represents the char at ith index
            //                 //Concat character to string.
            //                 result += str[i];
            //             }
            //             //return string result
            //             return result;

            //Approach 2: Using Array.Reverse Method                                                                              
            // optimization: array split, reverse, then initiating a new string instance of array[char]
            char[] array = str.ToCharArray();
            Array.Reverse(array);
            return new String(array);
        }
    }
}
