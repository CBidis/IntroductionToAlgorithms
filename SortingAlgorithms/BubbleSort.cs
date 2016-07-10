using System;

namespace SortingAlgorithms
{
    public class BubbleSort<T> where T : IComparable<T>
    {
        /// <summary>
        /// It sorts the elements of the input array in an increasing order
        /// using the bubble sort algorithm.
        /// </summary>
        /// <param name="elements"></param>
        public void Run(T[] elements)
        {
            for (int i = 0; i < elements.Length - 1; i++)
            {
                for (int j = elements.Length - 1; j > i; j--)
                {
                    if (elements[j - 1].CompareTo(elements[j]) > 0)
                    {
                        var temp = elements[j - 1];
                        elements[j - 1] = elements[j];
                        elements[j] = temp;
                    }
                }
            }
        }
    }
}