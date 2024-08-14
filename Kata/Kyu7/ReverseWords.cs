using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.ReverseWords
{
    public class SolutionClass
    {
        public static string ReverseWords(string str)
        {
            string result = "";
            string[] arr = str.Split();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = arr[i].Length - 1; j >= 0; j--)
                {
                    result += arr[i][j];
                }
                result += " ";
            }
            return result.Trim();
        }
    }
}
