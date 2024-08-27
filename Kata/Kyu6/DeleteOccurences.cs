namespace Kata.Kyu6.DeleteOccurences
{
    public class SolutionClass
    {
        public static int[] DeleteNth(int[] arr, int x)
        {
            //Create a dictionary to keep track of count;
            Dictionary<int, int> map = new Dictionary<int, int>();

            //Track how big the result array should be
            int xOccurenceElements = arr.Length;

            //Iterate through the array
            for (int i = 0; i < arr.Length; i++)
            {
                //add the key only if it is greater than x;
                if (map.ContainsKey(arr[i]) && map[arr[i]] == x)
                {
                    arr[i] = -1;
                    xOccurenceElements--;
                }
                else
                {
                    if (map.ContainsKey(arr[i])) map[arr[i]]++;
                    else map[arr[i]] = 1;
                }
            }

            //Create a result int array
            int[] resultArr = new int[xOccurenceElements];

            int resultIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    resultArr[resultIndex] = arr[i];
                    resultIndex++;
                }
            }
            
            return resultArr;
        }
    }
}
