namespace Kata.CountingSheep
{
    public class SolutionClass
    {
        public static int CountSheeps(bool[] sheeps)
        {
            //TODO
            //Initiate sheep count int
            int sheepCount = 0;

            //Iterate through sheeps array
            for (int i = 0; i < sheeps.Length; i++)
            {
                if (sheeps[i] == true)
                {
                    sheepCount++;
                }
            }
            return sheepCount;
        }
    }
}
