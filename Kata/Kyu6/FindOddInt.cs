﻿#pragma warning disable IDE0130 // Namespace does not match folder structure
namespace Kata.Kyu6.findIt
#pragma warning restore IDE0130 // Namespace does not match folder structure
{
    public class SolutionClass
    {
        public static int Find_it(int[] seq)
        {
            //Create a dictionary
            Dictionary<int, int> map = [];

            for (int i = 0; i < seq.Length; i++)
            {
                if (!map.Remove(seq[i]))
                {
                    map.Add(seq[i], 1);
                }
            }

            int result = 0;

            foreach (KeyValuePair<int, int> element in map)
            {
                result += element.Key;
            }
            return result;
        }
    }
}