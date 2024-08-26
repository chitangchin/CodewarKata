namespace Kata.Kyu8.StringRepeat
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
