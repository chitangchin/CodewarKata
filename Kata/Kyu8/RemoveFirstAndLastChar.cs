namespace Kata.Kyu8.RemoveChar
{
    public class SolutionClass
    {
        public static string Remove_char(string s)
        {
            //Initate result string
            string result = "";
            for (int i = 1; i < s.Length - 1; i++)
            {
                //Exclude the first and last character of string
                result += s[i];
            }
            return result;
        }
    }
}
