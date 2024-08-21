namespace Kata.SquareSum
{
    using System.Linq;
    public class SolutionClass
    {
        //Approach 2: using lambda operator using System.Linq and Sum method.
        public static int SquareSum(int[] numbers) => numbers.Sum(el => el * el);

        //             /*
        //             Brute Force approach:
        //             iterate through the array and add the square sum of the current index element to result sum
        //             TC: O(n) (Iterating through the array n times such that n scales with input)
        //             SC: O(1) (We are only using one space of memory to store the sum, does not scale with input)
        //             */

        //             //Initate the result sum
        //             int resultSum = 0;

        //             //Iterate through the array
        //             for (int i = 0; i < numbers.Length; i++)
        //             {
        //                 //Concat the square of number[i] to result Sum
        //                 resultSum += numbers[i] * numbers[i];
        //             }

        //             //return int result
        //             return resultSum;    
    }
}
