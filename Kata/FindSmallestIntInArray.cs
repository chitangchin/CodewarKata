namespace Kata.FindSmallestIntInArray
{
    public class SolutionClass
    {
        public static int FindSmallestInt(int[] args)
        {
            //Initiate a smallest int variable
            int currentSmallestInt = args[0];

            //Iterate through the array
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] < currentSmallestInt)
                {
                    currentSmallestInt = args[i];
                }
            }
            return currentSmallestInt;
        }
    }
}
