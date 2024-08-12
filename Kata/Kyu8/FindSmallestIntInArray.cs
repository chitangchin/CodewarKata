namespace Kata.FindSmallestIntInArray
{
    public class SolutionClass
    {
        public static int FindSmallestInt(int[] args)
        {
            /*
            Given arr[int]
            algo: find smallest int in arr
            Output: return the smallest int

            Approach 1: TC:O(n) SC:O(1)  -------------
            Iterate through the array
            Keep a minimum variable and compare each value
            - if lower than minimum then update the value

            Approach 2: TC:O(n/2) SC:O(1)
            Create two pointers
            Iterate through the array while p1 < p2
            check if pointer 1 or pointer 2 is smaller than min if so then update
            */

            //         //Approach 1

            //         //initiate the minimum int variable
            //         int currentMin = args[0];

            //         //Iterate through the array
            //         for (int i = 0; i < args.Length; i++)
            //         {
            //             //Check if smaller than min
            //             if (args[i] < currentMin)
            //             {
            //                 currentMin = args[i];
            //             }
            //         }
            //         //Return the result min
            //         return currentMin;

            //Approach 2 Optimized approach -------------
            //TC: o(n/2) = O(n)
            //SC: o(1) = O(1)

            //Initiate two pointers
            int startPointer = 0;
            int endPointer = args.Length - 1;

            //Initiate a minimum value;
            int currentMin = args[0];

            //Iterate through the array while startPointer < endPointer
            while (startPointer < endPointer)
            {
                //Check if currentMin needs to be updated
                if (args[startPointer] < currentMin)
                {
                    currentMin = args[startPointer];
                }
                //Check if currentMin needs to be updated
                if (args[endPointer] < currentMin)
                {
                    currentMin = args[endPointer];
                }
                //Move start pointer up
                startPointer++;
                //Move the end pointer down
                endPointer--;
            }
            return currentMin;
        }
    }
}
