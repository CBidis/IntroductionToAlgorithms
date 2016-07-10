using System;

namespace SortingAlgorithms
{
    public class InsertionSort<T> where T : struct, IComparable<T>
    {
        /// <summary>
        /// It sorts the elements of the input array in an increasing order
        /// using the insertion sort algortihm.
        /// </summary>
        /// <param name="array"></param>
        public void Run(T[] array)
        {
            if (array == null) throw new ArgumentException("array cannot be null");
            for (int j = 1; j < array.Length; j++)
            {
                var key = array[j];
                // Insert elements[j] into the sorted sequence A[1..j-1]
                var i = j - 1;
                while (i >= 0
                    && array[i].CompareTo(key) > 0)
                {
                    array[i + 1] = array[i];
                    i = i - 1;
                }
                array[i + 1] = key;
            }
        }

        /// <summary>
        /// It sorts the elements of the input array in non increasing order
        /// using the insertion sort algorithm.
        /// </summary>
        /// <param name="array"></param>
        public void RunNonIncreasing(T[] array)
        {
            if (array == null) throw new ArgumentException("array cannot be null");
            for (int j = 1; j < array.Length; j++)
            {
                var key = array[j];
                // Insert elements[j] into the sorted sequence A[1..j-1]
                var i = j - 1;
                while (i >= 0
                    && array[i].CompareTo(key) < 0)
                {
                    array[i + 1] = array[i];
                    i = i - 1;
                }
                array[i + 1] = key;
            }
        }
    }
}