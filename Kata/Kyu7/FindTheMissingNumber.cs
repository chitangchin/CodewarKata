using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.Kyu7.FindTheMissingNumber
{
    public class SolutionClass
    {
        public static int MissingNo(int[] nums)
        {
            //Given unsorted array containging all integers from 0 - 100
            //One number is missing
            //Write a funciton to find and return this number
            int result = 5050;

            //Bruteforce approach: iterate through all 100 numbers O(100) at most time complexity is constant and not scaling
            for (int i = 0; i < nums.Length; i++)
            {
                result -= nums[i];
                //find the summation of 1 to 100: 5050 = (n * (n + 1)) / 2 where n = 100
            }
            return result;
        }
    }
}
