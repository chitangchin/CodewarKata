using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.StringRepeat
{
    public class SolutionClass
    {
        public static string RepeatStr(int n, string s)
        {
            //Initiate result string
            string result = "";

            for (int i = 1; i <= n; i++)
            {
                result += s;
            }
            return result;
        }
    }
}
