using System;

namespace SortingAlgorithms
{
    public static class ArrayExtensions
    {
        public static bool IsSortedAscending<T>(this T[] array) where T : struct, IComparable<T>
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1].CompareTo(array[i]) > 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsSortedDescending<T>(this T[] array) where T : struct, IComparable<T>
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1].CompareTo(array[i]) < 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}