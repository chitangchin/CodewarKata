namespace Kata.SumOfPositive
{
    public class SolutionClass
    {
        public static int PositiveSum(int[] arr)
        {
            //Initiate variable int sum
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                //If Postive add the sum
                if (arr[i] > 0)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }
    }
}
