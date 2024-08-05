namespace Kata.SquareSum
{
    public class SolutionClass
    {
        public static int SquareSum(int[] numbers)
        {
            //Initialize Result sum
            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i] * numbers[i];
            }
            return result;
        }
    }
}
