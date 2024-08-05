using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.CenturyFromYear
{
    public class SolutionClass
    {
        public static int СenturyFromYear(int year)
        {
            int century = year / 100;
            if ((year - (century * 100)) >= 1)
            {
                century += 1;
            }
            return century;
        }
    }
}
