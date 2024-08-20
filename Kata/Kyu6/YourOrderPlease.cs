using System.Diagnostics.Metrics;

namespace Kata.Kyu6.YourOrderPlease
{
    public class SolutionClass
    {
        public static string Order(string words)
        {
            //Edge Case
            if (words.Length == 0) return "";

            //first split the string words
            string[] wordList = words.Split();

            //Find the length of wordList
            string[] resultArr = new string[wordList.Length];

            //Iterate through wordList
            for (int i = 0; i < wordList.Length; i++)
            {
                //Iterate through letter.
                int letter = 0;
                while (!char.IsDigit(wordList[i][letter]))
                {
                    letter++;
                }
                char index = wordList[i][letter];
                resultArr[index - '1'] = wordList[i];
            }

            string result = "";

            for (int i = 0; i < resultArr.Length; i++)
            {
                result += resultArr[i] + " ";
            }
            return result.Trim();
        }
    }
}
