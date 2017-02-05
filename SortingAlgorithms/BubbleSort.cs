using System;
using SortingCommonLib;

namespace SortingAlgorithms
{
    public class BubbleSort<T> where T : IComparable<T>
    {
        /// <summary>
        /// It sorts the elements of the input array in an increasing order
        /// using the bubble sort algorithm.
        /// </summary>
        /// <param name="array"></param>
        public void Run(T[] array)
        {
            if (array == null) throw new ArgumentException("array cannot be null");
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = array.Length - 1; j > i; j--)
                {
                    if (array[j - 1].CompareTo(array[j]) > 0)
                    {
                        array.Swap(j - 1, j);
                    }
                }
            }
        }
    }
}