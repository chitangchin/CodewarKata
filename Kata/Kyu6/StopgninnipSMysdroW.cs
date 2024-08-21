using System.Linq;

namespace Kata.Kyu6.SpinWords
{
    public class SolutionClass
    {
        public static string SpinWords(string sentence)
        {
            //check if each word has more than 5 letters
            string[] words = sentence.Split();
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length >= 5)
                {
                    string reversedWord = "";
                    for (int j = words[i].Length - 1; j >= 0; j--)
                    {
                        reversedWord += words[i][j];
                    }
                    words[i] = reversedWord;
                }
            }
            return String.Join(" ", words);
        }
    }
}


/*
 * Description:
Write a function that takes in a string of one or more words, and returns the same string, but with all words that have five or more letters reversed (Just like the name of this Kata). Strings passed in will consist of only letters and spaces. Spaces will be included only when more than one word is present.

Examples:

"Hey fellow warriors"  --> "Hey wollef sroirraw" 
"This is a test        --> "This is a test" 
"This is another test" --> "This is rehtona test"
 */