namespace Kata.Kyu8.BasicMathOperation
{
    public class SolutionClass
    {
        public static double basicOp(char operation, double value1, double value2)
        {
            //if operation = + add
            if (operation == '+')
            {
                return value1 + value2;
            }
            else if (operation == '-')
            {
                return value1 - value2;
            }
            else if (operation == '*')
            {
                return value1 * value2;
            }
            else
            {
                return value1 / value2;
            }
        }
    }
}
