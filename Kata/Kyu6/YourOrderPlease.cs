namespace Kata.Kyu6.YourOrderPlease
{
    public class SolutionClass
    {
        public static string Order(string words)
        {
            //first split the string words
            string[] wordList = words.Split();

            //Find the length of wordList
            string[] resultArr = new string[wordList.Length];

            //Iterate through wordList
            for (int i = 0; i < wordList.Length; i++)
            {
                int index = -1;
                //Iterate through letter.
                while(index == -1)
                {
                    int letter = 0;
                    if (char.IsDigit(wordList[i][letter]))
                    {
                        index = wordList[i][letter] - '0';
                        break;
                    }
                }
                resultArr[index] = wordList[i];
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
