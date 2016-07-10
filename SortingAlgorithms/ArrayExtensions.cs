using System;

namespace SortingAlgorithms
{
    public static class ArrayExtensions
    {
        /// <summary>
        /// Check if a an array is sorted in an ascending order. 
        /// </summary>
        /// <typeparam name="T">The type of the array's elements.</typeparam>
        /// <param name="array">The array.</param>
        /// <returns></returns>
        public static bool IsSortedAscending<T>(this T[] array) where T : IComparable<T>
        {
            if (array == null) throw new ArgumentException("array cannot be null");

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1].CompareTo(array[i]) > 0)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Check if a an array is sorted in a descending order.
        /// </summary>
        /// <typeparam name="T">The type of the array's elements.</typeparam>
        /// <param name="array">The array.</param>
        /// <returns></returns>
        public static bool IsSortedDescending<T>(this T[] array) where T : IComparable<T>
        {
            if (array == null) throw new ArgumentException("array cannot be null");

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