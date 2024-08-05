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
