﻿namespace Kata.Kyu8.GrasshopperSummation
{
    public class SolutionClass
    {
        public static int summation(int num)
        {
            //Initialize int result variable
            int result = 0;

            //Iterate num times and find summation
            for (int i = 1; i <= num; i++)
            {
                //add int i to result
                result += i;
            }
            return result;
        }
    }
}
