namespace Kata.BeginnerReduceButGrow
{
    using System.Linq;
    public class SolutionClass
    {
        public static int Grow(int[] x)
        {
            return x.Aggregate(1, (acc, x) => acc * x); ;
        }
    }
}
