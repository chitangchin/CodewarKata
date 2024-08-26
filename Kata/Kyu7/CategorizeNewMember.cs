using System.Collections.Generic;

namespace Kata.Kyu7.CategorizeNewMember
{
    public class SolutionClass
    {
        public static IEnumerable<string> OpenOrSenior(int[][] data)
        {
            //to be senior - must be >= 55 years old and handicap > 7
            //Handicap range -2 to 26
            //Input a list of pairs
            string[] result = new string[data.Length];

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i][0] >= 55 && data[i][1] > 7)
                {
                    result[i] = "Senior";
                }
                else
                {
                    result[i] = "Open";
                }
            }

            return result;
        }
    }
}
