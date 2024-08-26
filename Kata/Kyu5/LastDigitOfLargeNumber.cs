namespace Kata.Kyu5.LastDigitOfLargeNumber
{
    using System.Numerics;
    public class SolutionClass
    {
        public static int GetLastDigit(BigInteger n1, BigInteger n2)
        {
            //Find the base digit

            string exponentNumber = n2.ToString();
            if (exponentNumber == "0") return 1;
            string baseNumber = n1.ToString();
            char lastDigitOfBase = baseNumber[baseNumber.Length - 1];

            //Switch case based on the base digit
            switch (lastDigitOfBase)
            {
                case '1': return 1;
                case '2':
                    if (n2 % 4 == 0) return 6;
                    else if (n2 % 4 == 1) return 2;
                    else if (n2 % 4 == 2) return 4;
                    else return 8;
                case '3':
                    if (n2 % 4 == 0) return 1;
                    else if (n2 % 4 == 1) return 3;
                    else if (n2 % 4 == 2) return 9;
                    else return 7;
                case '4':
                    if (n2 % 2 == 0) return 6;
                    else return 4;
                case '5': return 5;
                case '6': return 6;
                case '7':
                    if (n2 % 4 == 0) return 1;
                    else if (n2 % 4 == 1) return 7;
                    else if (n2 % 4 == 2) return 9;
                    else return 3;
                case '8':
                    if (n2 % 4 == 0) return 6;
                    else if (n2 % 4 == 1) return 8;
                    else if (n2 % 4 == 2) return 4;
                    else return 2;
                case '9':
                    if (n2 % 2 == 0) return 1;
                    else return 9;
                default: return 0;
            }
        }
    }
}
