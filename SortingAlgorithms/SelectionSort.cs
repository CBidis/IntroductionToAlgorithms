using System;

namespace SortingAlgorithms
{
    public class SelectionSort<T> where T : IComparable<T>
    {
        /// <summary>
        /// It sorts the elements of the input array in an increasing order
        /// using the selection sort algortihm.
        /// </summary>
        /// <param name="elements"></param>
        public void Run(T[] array)
        {
            if (array == null) throw new ArgumentException("array cannot be null");
            for (var i = 0; i < array.Length - 1; i++)
            {
                int indexOfSmallest = i;
                for (var j = i + 1; j < array.Length; j++)
                {
                    if (array[indexOfSmallest].CompareTo(array[j]) > 0)
                    {
                        indexOfSmallest = j;
                    }
                }
                if (indexOfSmallest != i)
                {
                    var temp = array[i];
                    array[i] = array[indexOfSmallest];
                    array[indexOfSmallest] = temp;
                }
            }
        }
    }
}