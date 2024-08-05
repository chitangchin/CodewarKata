namespace Kata.ReversedString
{
    public class SolutionClass
    {
        public static string Solution(string str)
        {
            //Initiate String result Variable
            string result = "";
            //Iterate through the string from the end to the beginning
            for (int i = str.Length - 1; i >= 0; i--)
            {
                //str[i] represents the char at ith index
                //Concat character to string.
                result += str[i];
            }
            //return string result
            return result;
        }
    }
}
