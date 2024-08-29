using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.Kyu7.PrinterErrors
{
    public class SolutionClass
    {
        public static string PrinterError(String s)
        {
            Dictionary<char, int> map = new Dictionary<char, int>
            {
              {'a',1}, {'b', 1}, {'c',1}, {'d', 1}, {'e',1}, {'f', 1}, {'g',1}, {'h', 1},
              {'i',1}, {'j', 1}, {'k',1}, {'l', 1}, {'m',1}
            };

            int incorrectCount = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (!map.ContainsKey(s[i]))
                {
                    incorrectCount++;
                }
            }
            return $"{incorrectCount}/{s.Length}";
        }
    }
}
