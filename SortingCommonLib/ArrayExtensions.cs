using System;

namespace SortingCommonLib
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

        /// <summary>
        /// It swaps two elements of the array by providing their indices. 
        /// </summary>
        /// <typeparam name="T">The type of the array's elements.</typeparam>
        /// <param name="array">The array.</param>
        /// <param name="indexOfA">The index of the A element.</param>
        /// <param name="indexOfB">The index of the B element.</param>
        public static void Swap<T>(this T[] array, int indexOfA, int indexOfB)
        {
            if(array==null) throw new ArgumentException("array cannot be null");

            if (indexOfA < 0
             || indexOfA > array.Length - 1)
            {
                throw new ArgumentOutOfRangeException($"indexOfA is out of the expected range [0,{array.Length - 1}]");
            }

            if (indexOfB < 0
             || indexOfB > array.Length - 1)
            {
                throw new ArgumentOutOfRangeException($"indexOfA is out of the expected range [0,{array.Length - 1}]");
            }

            T temp = array[indexOfA];
            array[indexOfA] = array[indexOfB];
            array[indexOfB] = temp;
        }
    }
}