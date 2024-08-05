namespace Kata.RemoveStringSpace
{
    public class SolutionClass
    {
        public static string NoSpace(string input)
        {
            //Initiate result string
            string result = "";

            //Iterate through string
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    result += input[i];
                }
            }
            return result;
        }
    }
}
