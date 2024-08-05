namespace Kata.AbbrevName
{
    public class SolutionClass
    {
        public static string AbbrevName(string name)
        {
            //Get the first letter in the string and apply uppercase method.
            char firstInitial = char.ToUpper(name[0]);

            for (int i = 1; i < name.Length; i++)
            {
                if (char.IsWhiteSpace(name[i]))
                {
                    //Get the second letter (after first space) and apply uppercase and return early.
                    return $"{firstInitial}.{char.ToUpper(name[i + 1])}";
                }
            }
            return "Invalid Input";
        }
    }
}
